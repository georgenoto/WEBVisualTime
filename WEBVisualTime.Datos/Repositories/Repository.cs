using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WEBVisualTime.Datos.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await IncludeNavigations(_dbSet).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(object id)
    {
        var keyName = _context.Model.FindEntityType(typeof(T))?.FindPrimaryKey()?.Properties
            .FirstOrDefault()?.Name ?? "id";
        return await IncludeNavigations(_dbSet)
            .FirstOrDefaultAsync(e => EF.Property<object>(e, keyName).Equals(id));
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await IncludeNavigations(_dbSet).Where(predicate).ToListAsync();
    }

    private IQueryable<T> IncludeNavigations(IQueryable<T> query)
    {
        var entityType = _context.Model.FindEntityType(typeof(T));
        if (entityType == null) return query;

        foreach (var nav in entityType.GetNavigations())
        {
            query = query.Include(nav.Name);
        }
        return query;
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
