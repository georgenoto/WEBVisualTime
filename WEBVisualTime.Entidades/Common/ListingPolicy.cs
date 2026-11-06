namespace WEBVisualTime.Entidades.Common;

public static class ListingPolicy
{
    public const int DefaultPageSize = 20;
    public const int PageSize = DefaultPageSize;
    public const int MaximumPageSize = 100;
    public const int MaximumSearchLength = 100;
    public static int NormalizePageSize(int pageSize) => pageSize is >= 1 and <= MaximumPageSize ? pageSize : DefaultPageSize;
    public static int NormalizePage(int page, int pageSize = DefaultPageSize)
        => Math.Clamp(page, 1, int.MaxValue / NormalizePageSize(pageSize));
    public static string? NormalizeSearch(string? search)
    {
        search = search?.Trim();
        if (string.IsNullOrEmpty(search)) return null;
        return search.Length > MaximumSearchLength ? search[..MaximumSearchLength] : search;
    }
}
