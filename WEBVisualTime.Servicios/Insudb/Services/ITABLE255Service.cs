using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE255;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE255Service : IService<TABLE255Dto, CreateTABLE255Dto, UpdateTABLE255Dto, long>
{
    Task<IEnumerable<TABLE255Dto>> FindAsync(Expression<Func<TABLE255, bool>> predicate);
}
