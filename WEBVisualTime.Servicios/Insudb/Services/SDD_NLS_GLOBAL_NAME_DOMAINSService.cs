using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_NLS_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_NLS_GLOBAL_NAME_DOMAINSService : ISDD_NLS_GLOBAL_NAME_DOMAINSService
{
    private readonly IRepository<SDD_NLS_GLOBAL_NAME_DOMAINS> _repository;

    public SDD_NLS_GLOBAL_NAME_DOMAINSService(IRepository<SDD_NLS_GLOBAL_NAME_DOMAINS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SDD_NLS_GLOBAL_NAME_DOMAINSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_NLS_GLOBAL_NAME_DOMAINSDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SDD_NLS_GLOBAL_NAME_DOMAINSDto>> FindAsync(Expression<Func<SDD_NLS_GLOBAL_NAME_DOMAINS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_NLS_GLOBAL_NAME_DOMAINSDto> CreateAsync(CreateSDD_NLS_GLOBAL_NAME_DOMAINSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdateSDD_NLS_GLOBAL_NAME_DOMAINSDto updateDto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        entity.UpdateEntity(updateDto);
        _repository.Update(entity);
        await _repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        _repository.Remove(entity);
        await _repository.SaveChangesAsync();
        return true;
    }

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<SDD_NLS_GLOBAL_NAME_DOMAINSDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
