using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5674;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5674Service : IService<TABLE5674Dto, CreateTABLE5674Dto, UpdateTABLE5674Dto, int>
{
    Task<IEnumerable<TABLE5674Dto>> FindAsync(Expression<Func<TABLE5674, bool>> predicate);
}
