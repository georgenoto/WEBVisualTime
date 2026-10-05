using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE17;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE17Service : IService<TABLE17Dto, CreateTABLE17Dto, UpdateTABLE17Dto, long>
{
    Task<IEnumerable<TABLE17Dto>> FindAsync(Expression<Func<TABLE17, bool>> predicate);
}
