using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE149;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE149Service : IService<TABLE149Dto, CreateTABLE149Dto, UpdateTABLE149Dto, int>
{
    Task<IEnumerable<TABLE149Dto>> FindAsync(Expression<Func<TABLE149, bool>> predicate);
}
