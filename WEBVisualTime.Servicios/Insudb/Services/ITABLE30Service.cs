using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE30;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE30Service : IService<TABLE30Dto, CreateTABLE30Dto, UpdateTABLE30Dto, string>
{
    Task<IEnumerable<TABLE30Dto>> FindAsync(Expression<Func<TABLE30, bool>> predicate);
}
