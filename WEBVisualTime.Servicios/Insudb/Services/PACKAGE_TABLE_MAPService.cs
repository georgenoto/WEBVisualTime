using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PACKAGE_TABLE_MAP;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PACKAGE_TABLE_MAPService : IPACKAGE_TABLE_MAPService
{
    private readonly IRepository<PACKAGE_TABLE_MAP> _repository;

    public PACKAGE_TABLE_MAPService(IRepository<PACKAGE_TABLE_MAP> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PACKAGE_TABLE_MAPDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<PACKAGE_TABLE_MAPDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<PACKAGE_TABLE_MAPDto>> FindAsync(Expression<Func<PACKAGE_TABLE_MAP, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<PACKAGE_TABLE_MAPDto> CreateAsync(CreatePACKAGE_TABLE_MAPDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdatePACKAGE_TABLE_MAPDto updateDto)
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
