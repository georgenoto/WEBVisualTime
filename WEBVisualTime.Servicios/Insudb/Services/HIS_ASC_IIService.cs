using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_II;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class HIS_ASC_IIService : IHIS_ASC_IIService
{
    private readonly IRepository<HIS_ASC_II> _repository;

    public HIS_ASC_IIService(IRepository<HIS_ASC_II> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<HIS_ASC_IIDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<HIS_ASC_IIDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<HIS_ASC_IIDto>> FindAsync(Expression<Func<HIS_ASC_II, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<HIS_ASC_IIDto> CreateAsync(CreateHIS_ASC_IIDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateHIS_ASC_IIDto updateDto)
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

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<HIS_ASC_IIDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
