using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE531;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE531Service : IService<TABLE531Dto, CreateTABLE531Dto, UpdateTABLE531Dto, int>
{
    Task<IEnumerable<TABLE531Dto>> FindAsync(Expression<Func<TABLE531, bool>> predicate);
}
