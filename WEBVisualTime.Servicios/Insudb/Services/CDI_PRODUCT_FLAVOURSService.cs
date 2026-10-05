using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCT_FLAVOURS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CDI_PRODUCT_FLAVOURSService : ICDI_PRODUCT_FLAVOURSService
{
    private readonly IRepository<CDI_PRODUCT_FLAVOURS> _repository;

    public CDI_PRODUCT_FLAVOURSService(IRepository<CDI_PRODUCT_FLAVOURS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CDI_PRODUCT_FLAVOURSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_PRODUCT_FLAVOURSDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CDI_PRODUCT_FLAVOURSDto>> FindAsync(Expression<Func<CDI_PRODUCT_FLAVOURS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<CDI_PRODUCT_FLAVOURSDto> CreateAsync(CreateCDI_PRODUCT_FLAVOURSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCDI_PRODUCT_FLAVOURSDto updateDto)
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
