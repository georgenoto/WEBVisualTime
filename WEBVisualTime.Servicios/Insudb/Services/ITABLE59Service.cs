using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE59;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE59Service : IService<TABLE59Dto, CreateTABLE59Dto, UpdateTABLE59Dto, int>
{
    Task<IEnumerable<TABLE59Dto>> FindAsync(Expression<Func<TABLE59, bool>> predicate);
}
