using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8603Service : IService<TABLE8603Dto, CreateTABLE8603Dto, UpdateTABLE8603Dto, string>
{
    Task<IEnumerable<TABLE8603Dto>> FindAsync(Expression<Func<TABLE8603, bool>> predicate);
}
