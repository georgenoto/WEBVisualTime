using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5639Service : IService<TABLE5639Dto, CreateTABLE5639Dto, UpdateTABLE5639Dto, int>
{
    Task<IEnumerable<TABLE5639Dto>> FindAsync(Expression<Func<TABLE5639, bool>> predicate);
}
