using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE294;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE294Service : IService<TABLE294Dto, CreateTABLE294Dto, UpdateTABLE294Dto, int>
{
    Task<IEnumerable<TABLE294Dto>> FindAsync(Expression<Func<TABLE294, bool>> predicate);
}
