using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE99;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE99Service : IService<TABLE99Dto, CreateTABLE99Dto, UpdateTABLE99Dto, int>
{
    Task<IEnumerable<TABLE99Dto>> FindAsync(Expression<Func<TABLE99, bool>> predicate);
}
