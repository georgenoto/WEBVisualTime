using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7504;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7504Service : IService<TABLE7504Dto, CreateTABLE7504Dto, UpdateTABLE7504Dto, string>
{
    Task<IEnumerable<TABLE7504Dto>> FindAsync(Expression<Func<TABLE7504, bool>> predicate);
}
