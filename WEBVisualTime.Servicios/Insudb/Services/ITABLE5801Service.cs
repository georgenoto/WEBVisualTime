using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5801;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5801Service : IService<TABLE5801Dto, CreateTABLE5801Dto, UpdateTABLE5801Dto, int>
{
    Task<IEnumerable<TABLE5801Dto>> FindAsync(Expression<Func<TABLE5801, bool>> predicate);
}
