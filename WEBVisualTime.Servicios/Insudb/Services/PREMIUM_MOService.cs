using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_MO;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PREMIUM_MOService : IPREMIUM_MOService
{
    private readonly IRepository<PREMIUM_MO> _repository;

    public PREMIUM_MOService(IRepository<PREMIUM_MO> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PREMIUM_MODto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<PREMIUM_MODto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<PREMIUM_MODto>> FindAsync(Expression<Func<PREMIUM_MO, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<PREMIUM_MODto> CreateAsync(CreatePREMIUM_MODto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdatePREMIUM_MODto updateDto)
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

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<PREMIUM_MODto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
