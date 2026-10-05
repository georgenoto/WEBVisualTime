using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7046;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7046Service : IService<TABLE7046Dto, CreateTABLE7046Dto, UpdateTABLE7046Dto, int>
{
    Task<IEnumerable<TABLE7046Dto>> FindAsync(Expression<Func<TABLE7046, bool>> predicate);
}
