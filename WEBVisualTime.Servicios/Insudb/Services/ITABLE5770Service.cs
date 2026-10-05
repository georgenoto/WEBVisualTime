using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5770Service : IService<TABLE5770Dto, CreateTABLE5770Dto, UpdateTABLE5770Dto, int>
{
    Task<IEnumerable<TABLE5770Dto>> FindAsync(Expression<Func<TABLE5770, bool>> predicate);
}
