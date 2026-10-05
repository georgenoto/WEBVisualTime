using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE52Service : IService<TABLE52Dto, CreateTABLE52Dto, UpdateTABLE52Dto, string>
{
    Task<IEnumerable<TABLE52Dto>> FindAsync(Expression<Func<TABLE52, bool>> predicate);
}
