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
        return await IncludeNavigations(_dbSet.AsNoTracking()).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(object id)
    {
        ModelIntegrityRules.EnsureWritable(typeof(T));
        var keyName = _context.Model.FindEntityType(typeof(T))?.FindPrimaryKey()?.Properties
            .FirstOrDefault()?.Name ?? "id";
        return await IncludeNavigations(_dbSet)
            .FirstOrDefaultAsync(e => EF.Property<object>(e, keyName).Equals(id));
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await IncludeNavigations(_dbSet.AsNoTracking()).Where(predicate).ToListAsync();
    }

    public async Task<(IReadOnlyList<T> Items, long TotalCount, int Page)> GetPageAsync(
        int page, int pageSize, Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default)
    {
        pageSize = Math.Clamp(pageSize, 1, 100);
        page = Math.Clamp(page, 1, 1_000_000);
        var previousTimeout = _context.Database.GetCommandTimeout();
        try
        {
            // Interactive reads are bounded; other operations retain their configured timeout.
            _context.Database.SetCommandTimeout(30);
            IQueryable<T> query = _dbSet.AsNoTracking();
            if (predicate is not null) query = query.Where(predicate);
            var total = await query.LongCountAsync(cancellationToken);
            page = (int)Math.Min(page, Math.Max(1, (total + pageSize - 1) / pageSize));
            var items = await IncludeNavigations(query).OrderBy(orderBy)
                .Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);
            return (items, total, page);
        }
        finally
        {
            _context.Database.SetCommandTimeout(previousTimeout);
        }
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
        ModelIntegrityRules.EnsureWritable(typeof(T));
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        ModelIntegrityRules.EnsureWritable(typeof(T));
        _dbSet.Update(entity);
    }

    public void Remove(T entity)
    {
        ModelIntegrityRules.EnsureWritable(typeof(T));
        _dbSet.Remove(entity);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
