using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE22Service : IService<TABLE22Dto, CreateTABLE22Dto, UpdateTABLE22Dto, int>
{
    Task<IEnumerable<TABLE22Dto>> FindAsync(Expression<Func<TABLE22, bool>> predicate);
}
