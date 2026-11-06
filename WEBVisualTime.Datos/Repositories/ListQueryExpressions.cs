using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WEBVisualTime.Datos.Repositories;

internal static class ListQueryExpressions
{
    private static readonly MethodInfo CaptureMethod = typeof(ListQueryExpressions)
        .GetMethod(nameof(Capture), BindingFlags.Static | BindingFlags.NonPublic)!;
    private static Expression Capture<T>(T value)
    {
        Expression<Func<T>> expression = () => value;
        return expression.Body;
    }
    private static Expression Parameter(Type type, object value)
        => (Expression)CaptureMethod.MakeGenericMethod(type).Invoke(null, new[] { value })!;

    public static Expression<Func<T, bool>>? Search<T>(IEntityType entity, string? search)
    {
        if (string.IsNullOrWhiteSpace(search)) return null;
        var row = Expression.Parameter(typeof(T), "row");
        var conditions = new List<Expression>();
        var text = Capture(search.ToUpperInvariant());
        var numbers = new Dictionary<Type, Expression?>();
        var isDate = DateTime.TryParseExact(search, "yyyy-MM-dd", CultureInfo.InvariantCulture,
            DateTimeStyles.None, out var date) && date.Date < DateTime.MaxValue.Date;
        var start = isDate ? Capture(date.Date) : null;
        var end = isDate ? Capture(date.Date.AddDays(1)) : null;

        void AddFields(Expression instance, IEntityType type, Expression? navigationGuard = null)
        {
            foreach (var property in type.GetProperties().Where(p => p.PropertyInfo is not null && p.FindAnnotation("Listing:Searchable")?.Value is not false))
            {
                var member = Expression.Property(instance, property.PropertyInfo!);
                var valueType = Nullable.GetUnderlyingType(member.Type) ?? member.Type;
                Expression? match = null;
                if (valueType == typeof(string))
                {
                    var present = Expression.NotEqual(member, Expression.Constant(null, member.Type));
                    var upper = Expression.Call(member, nameof(string.ToUpper), Type.EmptyTypes);
                    match = Expression.AndAlso(present, Expression.Call(upper, nameof(string.Contains), Type.EmptyTypes, text));
                }
                else if (valueType == typeof(DateTime) && isDate)
                {
                    Expression lower = start!, upper = end!;
                    if (member.Type != valueType)
                    {
                        lower = Expression.Convert(lower, member.Type);
                        upper = Expression.Convert(upper, member.Type);
                    }
                    match = Expression.AndAlso(Expression.GreaterThanOrEqual(member, lower), Expression.LessThan(member, upper));
                }
                else if (valueType == typeof(int) || valueType == typeof(long) || valueType == typeof(short) ||
                         valueType == typeof(byte) || valueType == typeof(decimal) || valueType == typeof(double) || valueType == typeof(float))
                {
                    if (!numbers.TryGetValue(valueType, out var number))
                    {
                        try
                        {
                            var parsed = Convert.ChangeType(search, valueType, CultureInfo.InvariantCulture);
                            number = parsed is double d && !double.IsFinite(d) || parsed is float f && !float.IsFinite(f)
                                ? null : Parameter(valueType, parsed);
                        }
                        catch (Exception error) when (error is FormatException or OverflowException or InvalidCastException) { number = null; }
                        numbers[valueType] = number;
                    }
                    if (number is not null)
                        match = Expression.Equal(member, member.Type == valueType ? number : Expression.Convert(number, member.Type));
                }
                if (match is not null)
                    conditions.Add(navigationGuard is null ? match : Expression.AndAlso(navigationGuard, match));
            }
        }

        AddFields(row, entity);
        foreach (var navigation in entity.GetNavigations().Where(n => !n.IsCollection && n.PropertyInfo is not null))
        {
            var target = Expression.Property(row, navigation.PropertyInfo!);
            AddFields(target, navigation.TargetEntityType,
                Expression.NotEqual(target, Expression.Constant(null, target.Type)));
        }
        if (conditions.Count == 0) return Expression.Lambda<Func<T, bool>>(Expression.Constant(false), row);
        // Balance large predicates instead of producing a deeply nested OR chain.
        while (conditions.Count > 1)
        {
            var next = new List<Expression>();
            for (var i = 0; i < conditions.Count; i += 2)
                next.Add(i + 1 < conditions.Count ? Expression.OrElse(conditions[i], conditions[i + 1]) : conditions[i]);
            conditions = next;
        }
        return Expression.Lambda<Func<T, bool>>(conditions[0], row);
    }

    public static IOrderedQueryable<T> OrderByKeys<T>(IQueryable<T> query, IEntityType entity)
    {
        var key = entity.FindPrimaryKey() ?? throw new InvalidOperationException("A listing requires a configured row key.");
        var properties = key.Properties.ToList();
        if (ModelIntegrityRules.ReadOnlyReason(entity.ClrType.Name) is not null)
            properties.AddRange(entity.GetProperties().Where(p => !properties.Contains(p) && p.PropertyInfo is not null && p.ClrType != typeof(byte[])));
        Expression expression = query.Expression;
        for (var i = 0; i < properties.Count; i++)
        {
            var parameter = Expression.Parameter(typeof(T), "row");
            var member = Expression.Property(parameter, properties[i].PropertyInfo!);
            expression = Expression.Call(typeof(Queryable), i == 0 ? nameof(Queryable.OrderBy) : nameof(Queryable.ThenBy),
                new[] { typeof(T), member.Type }, expression, Expression.Quote(Expression.Lambda(member, parameter)));
        }
        return (IOrderedQueryable<T>)query.Provider.CreateQuery<T>(expression);
    }
}
