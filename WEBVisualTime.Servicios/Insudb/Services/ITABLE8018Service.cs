using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8018;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8018Service : IService<TABLE8018Dto, CreateTABLE8018Dto, UpdateTABLE8018Dto, int>
{
    Task<IEnumerable<TABLE8018Dto>> FindAsync(Expression<Func<TABLE8018, bool>> predicate);
}
