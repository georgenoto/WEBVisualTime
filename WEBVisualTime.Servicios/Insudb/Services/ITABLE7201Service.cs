using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7201;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7201Service : IService<TABLE7201Dto, CreateTABLE7201Dto, UpdateTABLE7201Dto, int>
{
    Task<IEnumerable<TABLE7201Dto>> FindAsync(Expression<Func<TABLE7201, bool>> predicate);
}
