using System.Linq.Expressions;

namespace WEBVisualTime.Datos.Repositories;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<(IReadOnlyList<T> Items, long TotalCount, int Page)> GetListPageAsync(
        int page, string? search = null, CancellationToken cancellationToken = default, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize);
    Task<T?> GetByIdAsync(object id);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task<(IReadOnlyList<T> Items, long TotalCount, int Page)> GetPageAsync(
        int page, int pageSize, Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default);
    Task AddAsync(T entity);
    void Update(T entity);
    void Remove(T entity);
    Task<int> SaveChangesAsync();
}
