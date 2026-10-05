using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GEN_TARGET_PROPERTIES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_GEN_TARGET_PROPERTIESService : ICDI_GEN_TARGET_PROPERTIESService
{
    private readonly IRepository<CDI_GEN_TARGET_PROPERTIES> _repository;

    public CDI_GEN_TARGET_PROPERTIESService(IRepository<CDI_GEN_TARGET_PROPERTIES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_GEN_TARGET_PROPERTIESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_GEN_TARGET_PROPERTIESDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_GEN_TARGET_PROPERTIESDto>> FindAsync(Expression<Func<CDI_GEN_TARGET_PROPERTIES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_GEN_TARGET_PROPERTIESDto> CreateAsync(CreateCDI_GEN_TARGET_PROPERTIESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCDI_GEN_TARGET_PROPERTIESDto updateDto)
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
