using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.RETENTIONCOV;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class RETENTIONCOVService : IRETENTIONCOVService
{
    private readonly IRepository<RETENTIONCOV> _repository;

    public RETENTIONCOVService(IRepository<RETENTIONCOV> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<RETENTIONCOVDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<RETENTIONCOVDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<RETENTIONCOVDto>> FindAsync(Expression<Func<RETENTIONCOV, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<RETENTIONCOVDto> CreateAsync(CreateRETENTIONCOVDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateRETENTIONCOVDto updateDto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        entity.UpdateEntity(updateDto);
        _repository.Update(entity);
        await _repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        _repository.Remove(entity);
        await _repository.SaveChangesAsync();
        return true;
    }

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<RETENTIONCOVDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
