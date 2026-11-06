namespace WEBVisualTime.Servicios.Services.Common;

public sealed record PagedResult<T>(IReadOnlyList<T> Items, long TotalCount, int Page, int PageSize)
{
    public long TotalPages => Math.Max(1, (TotalCount + PageSize - 1) / PageSize);
}
