using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE50Service : IService<TABLE50Dto, CreateTABLE50Dto, UpdateTABLE50Dto, string>
{
    Task<IEnumerable<TABLE50Dto>> FindAsync(Expression<Func<TABLE50, bool>> predicate);
}
