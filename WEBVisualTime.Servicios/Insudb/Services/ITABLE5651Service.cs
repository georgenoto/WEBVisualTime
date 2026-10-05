using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5651;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5651Service : IService<TABLE5651Dto, CreateTABLE5651Dto, UpdateTABLE5651Dto, int>
{
    Task<IEnumerable<TABLE5651Dto>> FindAsync(Expression<Func<TABLE5651, bool>> predicate);
}
