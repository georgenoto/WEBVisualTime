using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_DEPENDENCY_TYPESService : ISDD_DEPENDENCY_TYPESService
{
    private readonly IRepository<SDD_DEPENDENCY_TYPES> _repository;

    public SDD_DEPENDENCY_TYPESService(IRepository<SDD_DEPENDENCY_TYPES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SDD_DEPENDENCY_TYPESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_DEPENDENCY_TYPESDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SDD_DEPENDENCY_TYPESDto>> FindAsync(Expression<Func<SDD_DEPENDENCY_TYPES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_DEPENDENCY_TYPESDto> CreateAsync(CreateSDD_DEPENDENCY_TYPESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdateSDD_DEPENDENCY_TYPESDto updateDto)
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
