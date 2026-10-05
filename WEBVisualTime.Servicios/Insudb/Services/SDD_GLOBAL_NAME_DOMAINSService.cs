using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SDD_GLOBAL_NAME_DOMAINSService : ISDD_GLOBAL_NAME_DOMAINSService
{
    private readonly IRepository<SDD_GLOBAL_NAME_DOMAINS> _repository;

    public SDD_GLOBAL_NAME_DOMAINSService(IRepository<SDD_GLOBAL_NAME_DOMAINS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SDD_GLOBAL_NAME_DOMAINSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_GLOBAL_NAME_DOMAINSDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SDD_GLOBAL_NAME_DOMAINSDto>> FindAsync(Expression<Func<SDD_GLOBAL_NAME_DOMAINS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SDD_GLOBAL_NAME_DOMAINSDto> CreateAsync(CreateSDD_GLOBAL_NAME_DOMAINSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdateSDD_GLOBAL_NAME_DOMAINSDto updateDto)
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
