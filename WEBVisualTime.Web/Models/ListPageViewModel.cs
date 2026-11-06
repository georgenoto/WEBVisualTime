using System.Collections.Concurrent;
using System.Reflection;
using WEBVisualTime.Entidades.Common;

namespace WEBVisualTime.Web.Models;

public sealed record ListPageViewModel
{
    private static readonly ConcurrentDictionary<Type, IReadOnlyDictionary<string, PropertyInfo>> Properties = new();
    public CrudDefinition? Definition { get; init; }
    public IReadOnlyList<object> Items { get; init; } = Array.Empty<object>();
    public long TotalCount { get; init; }
    public int Page { get; init; } = 1;
    public int PageSize { get; init; } = ListingPolicy.DefaultPageSize;
    public long TotalPages => Math.Max(1, (TotalCount + PageSize - 1) / PageSize);
    public string? Search { get; init; }
    public string? ErrorMessage { get; init; }
    public string? ErrorReference { get; init; }
    public object? Value(object row, string property)
    {
        var map = Properties.GetOrAdd(row.GetType(), type => type.GetProperties().Where(p => p.CanRead)
            .ToDictionary(p => p.Name, StringComparer.Ordinal));
        return map.TryGetValue(property, out var info) ? info.GetValue(row) : null;
    }
}
