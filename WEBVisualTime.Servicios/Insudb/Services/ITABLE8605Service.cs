using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8605Service : IService<TABLE8605Dto, CreateTABLE8605Dto, UpdateTABLE8605Dto, string>
{
    Task<IEnumerable<TABLE8605Dto>> FindAsync(Expression<Func<TABLE8605, bool>> predicate);
}
