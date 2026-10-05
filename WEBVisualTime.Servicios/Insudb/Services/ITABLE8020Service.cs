using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8020;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8020Service : IService<TABLE8020Dto, CreateTABLE8020Dto, UpdateTABLE8020Dto, long>
{
    Task<IEnumerable<TABLE8020Dto>> FindAsync(Expression<Func<TABLE8020, bool>> predicate);
}
