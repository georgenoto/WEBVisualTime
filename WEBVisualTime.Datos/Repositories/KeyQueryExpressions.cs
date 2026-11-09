using System.Linq.Expressions;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata;
using WEBVisualTime.Entidades.Common;

namespace WEBVisualTime.Datos.Repositories;

internal static class KeyQueryExpressions
{
    public static Expression<Func<T, bool>> Match<T>(IEntityType entity, object id)
    {
        var properties = entity.FindPrimaryKey()?.Properties
            ?? throw new InvalidOperationException("A record requires a primary key.");
        var values = properties.Count > 1
            ? RecordKeys.Decode(entity.ClrType.Name, id as string)
            : new[] { System.Text.Json.JsonSerializer.SerializeToElement(id) };
        var row = Expression.Parameter(typeof(T), "row");
        Expression? condition = null;
        for (var i = 0; i < properties.Count; i++)
        {
            var property = properties[i];
            object value;
            try
            {
                value = values[i].Deserialize(property.ClrType)
                    ?? throw new RecordKeyException();
            }
            catch (System.Text.Json.JsonException) { throw new RecordKeyException(); }
            var member = Expression.Property(row, property.PropertyInfo!);
            var equal = Expression.Equal(member, ListQueryExpressions.Parameter(property.ClrType, value));
            condition = condition is null ? equal : Expression.AndAlso(condition, equal);
        }
        return Expression.Lambda<Func<T, bool>>(condition!, row);
    }
}
