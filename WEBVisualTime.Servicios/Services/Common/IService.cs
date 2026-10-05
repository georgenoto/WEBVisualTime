namespace WEBVisualTime.Servicios.Services.Common;

public interface IService<TDto, TCreateDto, TUpdateDto, TKey>
    where TDto : class
    where TCreateDto : class
    where TUpdateDto : class
{
    Task<IEnumerable<TDto>> GetAllAsync();
    Task<TDto?> GetByIdAsync(TKey id);
    Task<TDto> CreateAsync(TCreateDto createDto);
    Task<bool> UpdateAsync(TKey id, TUpdateDto updateDto);
    Task<bool> DeleteAsync(TKey id);
}
