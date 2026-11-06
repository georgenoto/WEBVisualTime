namespace WEBVisualTime.Servicios.Services.Common;

public interface IService<TDto, TCreateDto, TUpdateDto, TKey>
    where TDto : class
    where TCreateDto : class
    where TUpdateDto : class
{
    Task<IEnumerable<TDto>> GetAllAsync();
    Task<PagedResult<TDto>> GetListPageAsync(int page = 1, string? search = null,
        CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize);
    Task<TDto?> GetByIdAsync(TKey id);
    Task<TDto> CreateAsync(TCreateDto createDto);
    Task<bool> UpdateAsync(TKey id, TUpdateDto updateDto);
    Task<bool> DeleteAsync(TKey id);
}
