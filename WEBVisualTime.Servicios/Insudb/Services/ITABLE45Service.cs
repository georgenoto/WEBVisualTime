using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE45;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE45Service : IService<TABLE45Dto, CreateTABLE45Dto, UpdateTABLE45Dto, string>
{
    Task<IEnumerable<TABLE45Dto>> FindAsync(Expression<Func<TABLE45, bool>> predicate);
}
