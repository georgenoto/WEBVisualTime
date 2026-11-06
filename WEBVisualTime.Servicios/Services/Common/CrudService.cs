using System.Linq.Expressions;
using WEBVisualTime.Datos.Repositories;

namespace WEBVisualTime.Servicios.Services.Common;

// Keep entity mappings explicit while sharing the generated CRUD workflow.
public abstract class CrudService<TEntity, TDto, TCreateDto, TUpdateDto, TKey>
    : IService<TDto, TCreateDto, TUpdateDto, TKey>
    where TEntity : class where TDto : class where TCreateDto : class where TUpdateDto : class
{
    private readonly IRepository<TEntity> repository;
    private readonly Func<TEntity, TDto> toDto;
    private readonly Func<TCreateDto, TEntity> toEntity;
    private readonly Action<TEntity, TUpdateDto> updateEntity;

    protected CrudService(IRepository<TEntity> repository, Func<TEntity, TDto> toDto,
        Func<TCreateDto, TEntity> toEntity, Action<TEntity, TUpdateDto> updateEntity)
    {
        this.repository = repository;
        this.toDto = toDto;
        this.toEntity = toEntity;
        this.updateEntity = updateEntity;
    }

    public async Task<IEnumerable<TDto>> GetAllAsync() => (await repository.GetAllAsync()).Select(toDto);
    public async Task<TDto?> GetByIdAsync(TKey id)
    {
        var entity = await repository.GetByIdAsync(id!);
        return entity is null ? null : toDto(entity);
    }
    public async Task<IEnumerable<TDto>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        => (await repository.FindAsync(predicate)).Select(toDto);
    public async Task<TDto> CreateAsync(TCreateDto dto)
    {
        var entity = toEntity(dto);
        await repository.AddAsync(entity);
        await repository.SaveChangesAsync();
        return toDto(entity);
    }
    public async Task<bool> UpdateAsync(TKey id, TUpdateDto dto)
    {
        var entity = await repository.GetByIdAsync(id!);
        if (entity is null) return false;
        updateEntity(entity, dto);
        repository.Update(entity);
        await repository.SaveChangesAsync();
        return true;
    }
    public async Task<bool> DeleteAsync(TKey id)
    {
        var entity = await repository.GetByIdAsync(id!);
        if (entity is null) return false;
        repository.Remove(entity);
        await repository.SaveChangesAsync();
        return true;
    }
}
