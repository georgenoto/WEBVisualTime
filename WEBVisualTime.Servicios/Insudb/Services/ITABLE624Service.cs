using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE624;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE624Service : IService<TABLE624Dto, CreateTABLE624Dto, UpdateTABLE624Dto, int>
{
    Task<IEnumerable<TABLE624Dto>> FindAsync(Expression<Func<TABLE624, bool>> predicate);
}
