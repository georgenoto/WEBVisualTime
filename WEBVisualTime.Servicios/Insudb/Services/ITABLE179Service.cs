using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE179;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE179Service : IService<TABLE179Dto, CreateTABLE179Dto, UpdateTABLE179Dto, int>
{
    Task<IEnumerable<TABLE179Dto>> FindAsync(Expression<Func<TABLE179, bool>> predicate);
}
