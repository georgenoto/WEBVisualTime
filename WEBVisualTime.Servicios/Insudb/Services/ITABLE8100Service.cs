using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8100;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8100Service : IService<TABLE8100Dto, CreateTABLE8100Dto, UpdateTABLE8100Dto, int>
{
    Task<IEnumerable<TABLE8100Dto>> FindAsync(Expression<Func<TABLE8100, bool>> predicate);
}
