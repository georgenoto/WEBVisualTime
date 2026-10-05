using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5622;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5622Service : IService<TABLE5622Dto, CreateTABLE5622Dto, UpdateTABLE5622Dto, int>
{
    Task<IEnumerable<TABLE5622Dto>> FindAsync(Expression<Func<TABLE5622, bool>> predicate);
}
