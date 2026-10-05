using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS_PRECLAIM;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class DOCUMENTS_PRECLAIMService : IDOCUMENTS_PRECLAIMService
{
    private readonly IRepository<DOCUMENTS_PRECLAIM> _repository;

    public DOCUMENTS_PRECLAIMService(IRepository<DOCUMENTS_PRECLAIM> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<DOCUMENTS_PRECLAIMDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<DOCUMENTS_PRECLAIMDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<DOCUMENTS_PRECLAIMDto>> FindAsync(Expression<Func<DOCUMENTS_PRECLAIM, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<DOCUMENTS_PRECLAIMDto> CreateAsync(CreateDOCUMENTS_PRECLAIMDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(long id, UpdateDOCUMENTS_PRECLAIMDto updateDto)
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
