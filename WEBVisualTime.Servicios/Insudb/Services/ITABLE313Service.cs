using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE313;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE313Service : IService<TABLE313Dto, CreateTABLE313Dto, UpdateTABLE313Dto, int>
{
    Task<IEnumerable<TABLE313Dto>> FindAsync(Expression<Func<TABLE313, bool>> predicate);
}
