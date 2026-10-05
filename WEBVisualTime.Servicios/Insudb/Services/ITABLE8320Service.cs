using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8320;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8320Service : IService<TABLE8320Dto, CreateTABLE8320Dto, UpdateTABLE8320Dto, int>
{
    Task<IEnumerable<TABLE8320Dto>> FindAsync(Expression<Func<TABLE8320, bool>> predicate);
}
