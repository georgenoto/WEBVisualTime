using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE277;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE277Service : IService<TABLE277Dto, CreateTABLE277Dto, UpdateTABLE277Dto, int>
{
    Task<IEnumerable<TABLE277Dto>> FindAsync(Expression<Func<TABLE277, bool>> predicate);
}
