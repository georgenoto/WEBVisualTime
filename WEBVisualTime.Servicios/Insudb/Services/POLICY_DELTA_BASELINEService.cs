using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_DELTA_BASELINE;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class POLICY_DELTA_BASELINEService : IPOLICY_DELTA_BASELINEService
{
    private readonly IRepository<POLICY_DELTA_BASELINE> _repository;

    public POLICY_DELTA_BASELINEService(IRepository<POLICY_DELTA_BASELINE> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<POLICY_DELTA_BASELINEDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<POLICY_DELTA_BASELINEDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<POLICY_DELTA_BASELINEDto>> FindAsync(Expression<Func<POLICY_DELTA_BASELINE, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<POLICY_DELTA_BASELINEDto> CreateAsync(CreatePOLICY_DELTA_BASELINEDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdatePOLICY_DELTA_BASELINEDto updateDto)
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
