using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8004;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8004Service : IService<TABLE8004Dto, CreateTABLE8004Dto, UpdateTABLE8004Dto, int>
{
    Task<IEnumerable<TABLE8004Dto>> FindAsync(Expression<Func<TABLE8004, bool>> predicate);
}
