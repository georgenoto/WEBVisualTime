using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE360;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE360Service : IService<TABLE360Dto, CreateTABLE360Dto, UpdateTABLE360Dto, int>
{
    Task<IEnumerable<TABLE360Dto>> FindAsync(Expression<Func<TABLE360, bool>> predicate);
}
