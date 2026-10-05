using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE287;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE287Service : IService<TABLE287Dto, CreateTABLE287Dto, UpdateTABLE287Dto, long>
{
    Task<IEnumerable<TABLE287Dto>> FindAsync(Expression<Func<TABLE287, bool>> predicate);
}
