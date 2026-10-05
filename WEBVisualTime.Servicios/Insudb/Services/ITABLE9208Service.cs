using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9208;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9208Service : IService<TABLE9208Dto, CreateTABLE9208Dto, UpdateTABLE9208Dto, int>
{
    Task<IEnumerable<TABLE9208Dto>> FindAsync(Expression<Func<TABLE9208, bool>> predicate);
}
