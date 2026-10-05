using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_BRANCH;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SCHE_SURR_BRANCHService : ISCHE_SURR_BRANCHService
{
    private readonly IRepository<SCHE_SURR_BRANCH> _repository;

    public SCHE_SURR_BRANCHService(IRepository<SCHE_SURR_BRANCH> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SCHE_SURR_BRANCHDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SCHE_SURR_BRANCHDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SCHE_SURR_BRANCHDto>> FindAsync(Expression<Func<SCHE_SURR_BRANCH, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SCHE_SURR_BRANCHDto> CreateAsync(CreateSCHE_SURR_BRANCHDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateSCHE_SURR_BRANCHDto updateDto)
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
}
