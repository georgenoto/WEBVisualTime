using System.Text.Json;

namespace WEBVisualTime.Entidades.Common;

// A URL-safe identifier, not an authentication token. Values retain JSON numeric/date precision.
public static partial class RecordKeys
{
    private sealed record KeyEnvelope(string Entity, JsonElement[] Values);
    public static bool IsComposite(string entity) => CompositeColumns.ContainsKey(entity);

    public static string Encode(string entity, object row)
    {
        if (!CompositeColumns.TryGetValue(entity, out var names)) throw new RecordKeyException();
        var values = names.Select(name =>
        {
            var value = row.GetType().GetProperty(name)?.GetValue(row) ?? throw new RecordKeyException();
            return JsonSerializer.SerializeToElement(value);
        }).ToArray();
        return "~" + Convert.ToBase64String(JsonSerializer.SerializeToUtf8Bytes(new KeyEnvelope(entity, values)))
            .TrimEnd('=').Replace('+', '-').Replace('/', '_');
    }

    public static JsonElement[] Decode(string entity, string? id)
    {
        if (!CompositeColumns.TryGetValue(entity, out var names) || string.IsNullOrEmpty(id)
            || !id.StartsWith('~') || id.Length > 16384) throw new RecordKeyException();
        try
        {
            var encoded = id[1..];
            if (encoded.Any(c => !char.IsAsciiLetterOrDigit(c) && c is not '-' and not '_'))
                throw new RecordKeyException();
            encoded = encoded.Replace('-', '+').Replace('_', '/');
            encoded = encoded.PadRight((encoded.Length + 3) / 4 * 4, '=');
            var key = JsonSerializer.Deserialize<KeyEnvelope>(Convert.FromBase64String(encoded));
            if (key?.Entity != entity || key.Values is null || key.Values.Length != names.Length
                || key.Values.Any(v => v.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined))
                throw new RecordKeyException();
            return key.Values;
        }
        catch (Exception error) when (error is FormatException or JsonException)
        {
            throw new RecordKeyException();
        }
    }

    public static IReadOnlyList<string> Columns(string entity)
        => CompositeColumns.TryGetValue(entity, out var columns) ? Array.AsReadOnly(columns) : Array.Empty<string>();
}
