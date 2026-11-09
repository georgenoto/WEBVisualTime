using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_MOV;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class BANK_MOVService : IBANK_MOVService
{
    private readonly IRepository<BANK_MOV> _repository;

    public BANK_MOVService(IRepository<BANK_MOV> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<BANK_MOVDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<BANK_MOVDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<BANK_MOVDto>> FindAsync(Expression<Func<BANK_MOV, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<BANK_MOVDto> CreateAsync(CreateBANK_MOVDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateBANK_MOVDto updateDto)
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

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<BANK_MOVDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
