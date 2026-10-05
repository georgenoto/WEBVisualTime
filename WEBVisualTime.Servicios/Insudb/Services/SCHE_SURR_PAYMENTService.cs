using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_PAYMENT;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class SCHE_SURR_PAYMENTService : ISCHE_SURR_PAYMENTService
{
    private readonly IRepository<SCHE_SURR_PAYMENT> _repository;

    public SCHE_SURR_PAYMENTService(IRepository<SCHE_SURR_PAYMENT> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SCHE_SURR_PAYMENTDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto());
    }

    public async Task<SCHE_SURR_PAYMENTDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<SCHE_SURR_PAYMENTDto>> FindAsync(Expression<Func<SCHE_SURR_PAYMENT, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto());
    }

    public async Task<SCHE_SURR_PAYMENTDto> CreateAsync(CreateSCHE_SURR_PAYMENTDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateSCHE_SURR_PAYMENTDto updateDto)
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
