using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CLASS_SET_CODE_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_CLASS_SET_CODE_TYPESService : ICDI_CLASS_SET_CODE_TYPESService
{
    private readonly IRepository<CDI_CLASS_SET_CODE_TYPES> _repository;

    public CDI_CLASS_SET_CODE_TYPESService(IRepository<CDI_CLASS_SET_CODE_TYPES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_CLASS_SET_CODE_TYPESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_CLASS_SET_CODE_TYPESDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_CLASS_SET_CODE_TYPESDto>> FindAsync(Expression<Func<CDI_CLASS_SET_CODE_TYPES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_CLASS_SET_CODE_TYPESDto> CreateAsync(CreateCDI_CLASS_SET_CODE_TYPESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCDI_CLASS_SET_CODE_TYPESDto updateDto)
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
