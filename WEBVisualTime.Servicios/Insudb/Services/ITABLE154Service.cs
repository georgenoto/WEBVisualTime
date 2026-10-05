using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE154Service : IService<TABLE154Dto, CreateTABLE154Dto, UpdateTABLE154Dto, string>
{
    Task<IEnumerable<TABLE154Dto>> FindAsync(Expression<Func<TABLE154, bool>> predicate);
}
