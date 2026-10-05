using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5608;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5608Service : IService<TABLE5608Dto, CreateTABLE5608Dto, UpdateTABLE5608Dto, int>
{
    Task<IEnumerable<TABLE5608Dto>> FindAsync(Expression<Func<TABLE5608, bool>> predicate);
}
