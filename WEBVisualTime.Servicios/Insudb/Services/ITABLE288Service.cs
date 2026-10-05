using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE288;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE288Service : IService<TABLE288Dto, CreateTABLE288Dto, UpdateTABLE288Dto, int>
{
    Task<IEnumerable<TABLE288Dto>> FindAsync(Expression<Func<TABLE288, bool>> predicate);
}
