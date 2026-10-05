using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY_BIND;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class RM_LINK_CUSTOMIZED_QUERY_BINDService : IRM_LINK_CUSTOMIZED_QUERY_BINDService
{
    private readonly IRepository<RM_LINK_CUSTOMIZED_QUERY_BIND> _repository;

    public RM_LINK_CUSTOMIZED_QUERY_BINDService(IRepository<RM_LINK_CUSTOMIZED_QUERY_BIND> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<RM_LINK_CUSTOMIZED_QUERY_BINDDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<RM_LINK_CUSTOMIZED_QUERY_BINDDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<RM_LINK_CUSTOMIZED_QUERY_BINDDto>> FindAsync(Expression<Func<RM_LINK_CUSTOMIZED_QUERY_BIND, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<RM_LINK_CUSTOMIZED_QUERY_BINDDto> CreateAsync(CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto updateDto)
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
