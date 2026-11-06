using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class CLIENTService : ICLIENTService
{
    private readonly IRepository<CLIENT> _repository;

    public CLIENTService(IRepository<CLIENT> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CLIENTDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return entities.Select(e => e.ToDto()).ToList();
    }

    public async Task<CLIENTDto?> GetByIdAsync(string id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<CLIENTDto>> FindAsync(Expression<Func<CLIENT, bool>> predicate)
    {
        var entities = await _repository.FindAsync(predicate);
        return entities.Select(e => e.ToDto()).ToList();
    }

    public async Task<PagedResult<CLIENTDto>> GetPageAsync(int page, int pageSize,
        string? search = null, CancellationToken cancellationToken = default)
    {
        var term = search?.Trim().ToUpperInvariant();
        Expression<Func<CLIENT, bool>>? filter = string.IsNullOrEmpty(term) ? null : c =>
            c.SCLIENT.ToUpper().Contains(term) ||
            (c.SFIRSTNAME != null && c.SFIRSTNAME.ToUpper().Contains(term)) ||
            (c.SLASTNAME != null && c.SLASTNAME.ToUpper().Contains(term)) ||
            (c.SLEGALNAME != null && c.SLEGALNAME.ToUpper().Contains(term));
        pageSize = Math.Clamp(pageSize, 1, 100);
        var result = await _repository.GetPageAsync(page, pageSize, c => c.SCLIENT, filter, cancellationToken);
        return new(result.Items.Select(e => e.ToDto()).ToList(), result.TotalCount, result.Page, pageSize);
    }

    public async Task<CLIENTDto> CreateAsync(CreateCLIENTDto createDto)
    {
        var entity = createDto.ToEntity();
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.ToDto();
    }

    public async Task<bool> UpdateAsync(string id, UpdateCLIENTDto updateDto)
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

    public Task<WEBVisualTime.Servicios.Services.Common.PagedResult<CLIENTDto>> GetListPageAsync(
        int page = 1, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize)
        => WEBVisualTime.Servicios.Services.Common.PagedQueries.ReadAsync(
            _repository, e => e.ToDto(), page, search, cancellationToken, pageSize);
}
