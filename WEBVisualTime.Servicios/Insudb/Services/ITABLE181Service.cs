using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE181Service : IService<TABLE181Dto, CreateTABLE181Dto, UpdateTABLE181Dto, string>
{
    Task<IEnumerable<TABLE181Dto>> FindAsync(Expression<Func<TABLE181, bool>> predicate);
}
