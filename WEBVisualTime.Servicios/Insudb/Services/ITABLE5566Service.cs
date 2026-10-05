using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5566Service : IService<TABLE5566Dto, CreateTABLE5566Dto, UpdateTABLE5566Dto, int>
{
    Task<IEnumerable<TABLE5566Dto>> FindAsync(Expression<Func<TABLE5566, bool>> predicate);
}
