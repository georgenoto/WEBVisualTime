using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9002;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9002Service : IService<TABLE9002Dto, CreateTABLE9002Dto, UpdateTABLE9002Dto, int>
{
    Task<IEnumerable<TABLE9002Dto>> FindAsync(Expression<Func<TABLE9002, bool>> predicate);
}
