using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CODE_SECTION_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_CODE_SECTION_TYPESService : ICDI_CODE_SECTION_TYPESService
{
    private readonly IRepository<CDI_CODE_SECTION_TYPES> _repository;

    public CDI_CODE_SECTION_TYPESService(IRepository<CDI_CODE_SECTION_TYPES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_CODE_SECTION_TYPESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_CODE_SECTION_TYPESDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_CODE_SECTION_TYPESDto>> FindAsync(Expression<Func<CDI_CODE_SECTION_TYPES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_CODE_SECTION_TYPESDto> CreateAsync(CreateCDI_CODE_SECTION_TYPESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCDI_CODE_SECTION_TYPESDto updateDto)
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
