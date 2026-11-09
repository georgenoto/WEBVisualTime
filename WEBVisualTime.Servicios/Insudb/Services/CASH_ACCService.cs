using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CASH_ACCService : ICASH_ACCService
{
    private readonly IRepository<CASH_ACC> _repository;

    public CASH_ACCService(IRepository<CASH_ACC> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CASH_ACCDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CASH_ACCDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CASH_ACCDto>> FindAsync(Expression<Func<CASH_ACC, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CASH_ACCDto> CreateAsync(CreateCASH_ACCDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCASH_ACCDto updateDto)
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

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<CASH_ACCDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
