using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_DEPEND_STATUSESService : ISDD_DEPEND_STATUSESService
{
    private readonly IRepository<SDD_DEPEND_STATUSES> _repository;

    public SDD_DEPEND_STATUSESService(IRepository<SDD_DEPEND_STATUSES> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SDD_DEPEND_STATUSESDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_DEPEND_STATUSESDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SDD_DEPEND_STATUSESDto>> FindAsync(Expression<Func<SDD_DEPEND_STATUSES, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_DEPEND_STATUSESDto> CreateAsync(CreateSDD_DEPEND_STATUSESDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateSDD_DEPEND_STATUSESDto updateDto)
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
