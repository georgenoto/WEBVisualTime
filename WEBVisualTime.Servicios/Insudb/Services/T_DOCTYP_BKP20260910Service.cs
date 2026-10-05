using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP_BKP20260910;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class T_DOCTYP_BKP20260910Service : IT_DOCTYP_BKP20260910Service
{
    private readonly IRepository<T_DOCTYP_BKP20260910> _repository;

    public T_DOCTYP_BKP20260910Service(IRepository<T_DOCTYP_BKP20260910> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<T_DOCTYP_BKP20260910Dto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<T_DOCTYP_BKP20260910Dto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<T_DOCTYP_BKP20260910Dto>> FindAsync(Expression<Func<T_DOCTYP_BKP20260910, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<T_DOCTYP_BKP20260910Dto> CreateAsync(CreateT_DOCTYP_BKP20260910Dto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateT_DOCTYP_BKP20260910Dto updateDto)
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
