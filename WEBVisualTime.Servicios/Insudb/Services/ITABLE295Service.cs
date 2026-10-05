using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE295;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE295Service : IService<TABLE295Dto, CreateTABLE295Dto, UpdateTABLE295Dto, int>
{
    Task<IEnumerable<TABLE295Dto>> FindAsync(Expression<Func<TABLE295, bool>> predicate);
}
