using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE645;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE645Service : IService<TABLE645Dto, CreateTABLE645Dto, UpdateTABLE645Dto, long>
{
    Task<IEnumerable<TABLE645Dto>> FindAsync(Expression<Func<TABLE645, bool>> predicate);
}
