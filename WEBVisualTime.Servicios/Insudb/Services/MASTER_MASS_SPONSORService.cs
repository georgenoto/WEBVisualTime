using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTER_MASS_SPONSOR;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class MASTER_MASS_SPONSORService : IMASTER_MASS_SPONSORService
{
    private readonly IRepository<MASTER_MASS_SPONSOR> _repository;

    public MASTER_MASS_SPONSORService(IRepository<MASTER_MASS_SPONSOR> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MASTER_MASS_SPONSORDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<MASTER_MASS_SPONSORDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<MASTER_MASS_SPONSORDto>> FindAsync(Expression<Func<MASTER_MASS_SPONSOR, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<MASTER_MASS_SPONSORDto> CreateAsync(CreateMASTER_MASS_SPONSORDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdateMASTER_MASS_SPONSORDto updateDto)
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
}
