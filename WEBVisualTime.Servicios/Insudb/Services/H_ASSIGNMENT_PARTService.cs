using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class H_ASSIGNMENT_PARTService : IH_ASSIGNMENT_PARTService
{
    private readonly IRepository<H_ASSIGNMENT_PART> _repository;

    public H_ASSIGNMENT_PARTService(IRepository<H_ASSIGNMENT_PART> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<H_ASSIGNMENT_PARTDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<H_ASSIGNMENT_PARTDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<H_ASSIGNMENT_PARTDto>> FindAsync(Expression<Func<H_ASSIGNMENT_PART, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<H_ASSIGNMENT_PARTDto> CreateAsync(CreateH_ASSIGNMENT_PARTDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(long id, UpdateH_ASSIGNMENT_PARTDto updateDto)
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
