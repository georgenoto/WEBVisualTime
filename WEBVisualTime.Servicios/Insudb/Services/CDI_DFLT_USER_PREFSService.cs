using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREFS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_DFLT_USER_PREFSService : ICDI_DFLT_USER_PREFSService
{
    private readonly IRepository<CDI_DFLT_USER_PREFS> _repository;

    public CDI_DFLT_USER_PREFSService(IRepository<CDI_DFLT_USER_PREFS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_DFLT_USER_PREFSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_DFLT_USER_PREFSDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_DFLT_USER_PREFSDto>> FindAsync(Expression<Func<CDI_DFLT_USER_PREFS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_DFLT_USER_PREFSDto> CreateAsync(CreateCDI_DFLT_USER_PREFSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCDI_DFLT_USER_PREFSDto updateDto)
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
