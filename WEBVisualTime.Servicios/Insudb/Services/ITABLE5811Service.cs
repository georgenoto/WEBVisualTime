using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5811;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5811Service : IService<TABLE5811Dto, CreateTABLE5811Dto, UpdateTABLE5811Dto, int>
{
    Task<IEnumerable<TABLE5811Dto>> FindAsync(Expression<Func<TABLE5811, bool>> predicate);
}
