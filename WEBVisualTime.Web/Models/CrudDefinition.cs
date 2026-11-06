using System.Reflection;

namespace WEBVisualTime.Web.Models;

public sealed record CrudDefinition(string Name, string Key, string[] Columns)
{
    public object? Value(object row, string property) => row.GetType().GetProperty(property)?.GetValue(row);
    public PropertyInfo[] Fields(object model) => model.GetType().GetProperties()
        .Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0).ToArray();
}
