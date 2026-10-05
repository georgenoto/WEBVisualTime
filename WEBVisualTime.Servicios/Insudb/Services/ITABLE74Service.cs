using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE74;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE74Service : IService<TABLE74Dto, CreateTABLE74Dto, UpdateTABLE74Dto, long>
{
    Task<IEnumerable<TABLE74Dto>> FindAsync(Expression<Func<TABLE74, bool>> predicate);
}
