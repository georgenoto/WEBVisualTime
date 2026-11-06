using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.MUNICIPALITY;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class MUNICIPALITYService : IMUNICIPALITYService
{
    private readonly IRepository<MUNICIPALITY> _repository;

    public MUNICIPALITYService(IRepository<MUNICIPALITY> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MUNICIPALITYDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<MUNICIPALITYDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<MUNICIPALITYDto>> FindAsync(Expression<Func<MUNICIPALITY, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<MUNICIPALITYDto> CreateAsync(CreateMUNICIPALITYDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(long id, UpdateMUNICIPALITYDto updateDto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        entity.UpdateEntity(updateDto);
        _repository.Update(entity);
        await _repository.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        _repository.Remove(entity);
        await _repository.SaveChangesAsync();
        return true;
    }
}
