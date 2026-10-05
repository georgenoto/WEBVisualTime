using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7220;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7220Service : IService<TABLE7220Dto, CreateTABLE7220Dto, UpdateTABLE7220Dto, int>
{
    Task<IEnumerable<TABLE7220Dto>> FindAsync(Expression<Func<TABLE7220, bool>> predicate);
}
