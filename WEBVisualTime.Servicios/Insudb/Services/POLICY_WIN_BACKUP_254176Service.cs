using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN_BACKUP_254176;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class POLICY_WIN_BACKUP_254176Service : IPOLICY_WIN_BACKUP_254176Service
{
    private readonly IRepository<POLICY_WIN_BACKUP_254176> _repository;

    public POLICY_WIN_BACKUP_254176Service(IRepository<POLICY_WIN_BACKUP_254176> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<POLICY_WIN_BACKUP_254176Dto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<POLICY_WIN_BACKUP_254176Dto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<POLICY_WIN_BACKUP_254176Dto>> FindAsync(Expression<Func<POLICY_WIN_BACKUP_254176, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<POLICY_WIN_BACKUP_254176Dto> CreateAsync(CreatePOLICY_WIN_BACKUP_254176Dto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdatePOLICY_WIN_BACKUP_254176Dto updateDto)
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
