using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8Service : IService<TABLE8Dto, CreateTABLE8Dto, UpdateTABLE8Dto, string>
{
    Task<IEnumerable<TABLE8Dto>> FindAsync(Expression<Func<TABLE8, bool>> predicate);
}
