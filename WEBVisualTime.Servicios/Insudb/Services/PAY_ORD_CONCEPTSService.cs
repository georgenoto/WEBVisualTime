using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_ORD_CONCEPTS;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PAY_ORD_CONCEPTSService : IPAY_ORD_CONCEPTSService
{
    private readonly IRepository<PAY_ORD_CONCEPTS> _repository;

    public PAY_ORD_CONCEPTSService(IRepository<PAY_ORD_CONCEPTS> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PAY_ORD_CONCEPTSDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<PAY_ORD_CONCEPTSDto?> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<PAY_ORD_CONCEPTSDto>> FindAsync(Expression<Func<PAY_ORD_CONCEPTS, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<PAY_ORD_CONCEPTSDto> CreateAsync(CreatePAY_ORD_CONCEPTSDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(int id, UpdatePAY_ORD_CONCEPTSDto updateDto)
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
