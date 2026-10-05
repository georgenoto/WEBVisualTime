using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE88;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE88Service : IService<TABLE88Dto, CreateTABLE88Dto, UpdateTABLE88Dto, int>
{
    Task<IEnumerable<TABLE88Dto>> FindAsync(Expression<Func<TABLE88, bool>> predicate);
}
