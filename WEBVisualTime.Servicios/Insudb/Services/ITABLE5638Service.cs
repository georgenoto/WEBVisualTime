using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5638;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5638Service : IService<TABLE5638Dto, CreateTABLE5638Dto, UpdateTABLE5638Dto, int>
{
    Task<IEnumerable<TABLE5638Dto>> FindAsync(Expression<Func<TABLE5638, bool>> predicate);
}
