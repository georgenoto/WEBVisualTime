using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE200Service : IService<TABLE200Dto, CreateTABLE200Dto, UpdateTABLE200Dto, int>
{
    Task<IEnumerable<TABLE200Dto>> FindAsync(Expression<Func<TABLE200, bool>> predicate);
}
