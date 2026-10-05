using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class REINSU_PRIM_HEALTHService : IREINSU_PRIM_HEALTHService
{
    private readonly IRepository<REINSU_PRIM_HEALTH> _repository;

    public REINSU_PRIM_HEALTHService(IRepository<REINSU_PRIM_HEALTH> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<REINSU_PRIM_HEALTHDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<REINSU_PRIM_HEALTHDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<REINSU_PRIM_HEALTHDto>> FindAsync(Expression<Func<REINSU_PRIM_HEALTH, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<REINSU_PRIM_HEALTHDto> CreateAsync(CreateREINSU_PRIM_HEALTHDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdateREINSU_PRIM_HEALTHDto updateDto)
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
