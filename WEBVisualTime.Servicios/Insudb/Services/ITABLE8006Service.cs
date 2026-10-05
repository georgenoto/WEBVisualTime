using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8006Service : IService<TABLE8006Dto, CreateTABLE8006Dto, UpdateTABLE8006Dto, int>
{
    Task<IEnumerable<TABLE8006Dto>> FindAsync(Expression<Func<TABLE8006, bool>> predicate);
}
