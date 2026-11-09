using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Entidades.Common;

namespace WEBVisualTime.Servicios.Services.Common;

public static class PagedQueries
{
    public static async Task<PagedResult<TDto>> ReadAsync<TEntity, TDto>(IRepository<TEntity> repository,
        Func<TEntity, TDto> map, int page, string? search = null, CancellationToken cancellationToken = default, int pageSize = ListingPolicy.DefaultPageSize)
        where TEntity : class where TDto : class
    {
        pageSize = ListingPolicy.NormalizePageSize(pageSize);
        var result = await repository.GetListPageAsync(page, search, cancellationToken, pageSize);
        var items = result.Items.Select(map).ToList();
        return new(items, result.TotalCount, result.Page, pageSize)
        {
            RecordKeys = RecordKeys.IsComposite(typeof(TEntity).Name)
                ? items.Select(item => RecordKeys.Encode(typeof(TEntity).Name, item)).ToArray() : null
        };
    }
}
