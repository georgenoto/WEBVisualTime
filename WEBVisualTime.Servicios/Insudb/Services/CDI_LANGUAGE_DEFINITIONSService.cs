using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_LANGUAGE_DEFINITIONS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_LANGUAGE_DEFINITIONSService : ICDI_LANGUAGE_DEFINITIONSService
{
    private readonly IRepository<CDI_LANGUAGE_DEFINITIONS> _repository;

    public CDI_LANGUAGE_DEFINITIONSService(IRepository<CDI_LANGUAGE_DEFINITIONS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_LANGUAGE_DEFINITIONSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_LANGUAGE_DEFINITIONSDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_LANGUAGE_DEFINITIONSDto>> FindAsync(Expression<Func<CDI_LANGUAGE_DEFINITIONS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_LANGUAGE_DEFINITIONSDto> CreateAsync(CreateCDI_LANGUAGE_DEFINITIONSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(long id, UpdateCDI_LANGUAGE_DEFINITIONSDto updateDto)
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
