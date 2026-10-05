using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE33Service : IService<TABLE33Dto, CreateTABLE33Dto, UpdateTABLE33Dto, string>
{
    Task<IEnumerable<TABLE33Dto>> FindAsync(Expression<Func<TABLE33, bool>> predicate);
}
