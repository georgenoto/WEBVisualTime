using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE12Service : IService<TABLE12Dto, CreateTABLE12Dto, UpdateTABLE12Dto, int>
{
    Task<IEnumerable<TABLE12Dto>> FindAsync(Expression<Func<TABLE12, bool>> predicate);
}
