using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_ERROR;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class MASSIVE_LOG_ERRORService : IMASSIVE_LOG_ERRORService
{
    private readonly IRepository<MASSIVE_LOG_ERROR> _repository;

    public MASSIVE_LOG_ERRORService(IRepository<MASSIVE_LOG_ERROR> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MASSIVE_LOG_ERRORDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<MASSIVE_LOG_ERRORDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<MASSIVE_LOG_ERRORDto>> FindAsync(Expression<Func<MASSIVE_LOG_ERROR, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<MASSIVE_LOG_ERRORDto> CreateAsync(CreateMASSIVE_LOG_ERRORDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateMASSIVE_LOG_ERRORDto updateDto)
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
