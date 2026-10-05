using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PIE_ELEMENT_TYPESService : IPIE_ELEMENT_TYPESService
{
    private readonly IRepository<PIE_ELEMENT_TYPES> _repository;

    public PIE_ELEMENT_TYPESService(IRepository<PIE_ELEMENT_TYPES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PIE_ELEMENT_TYPESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<PIE_ELEMENT_TYPESDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<PIE_ELEMENT_TYPESDto>> FindAsync(Expression<Func<PIE_ELEMENT_TYPES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<PIE_ELEMENT_TYPESDto> CreateAsync(CreatePIE_ELEMENT_TYPESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdatePIE_ELEMENT_TYPESDto updateDto)
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
