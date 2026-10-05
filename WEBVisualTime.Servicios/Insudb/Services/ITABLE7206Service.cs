using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7206;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7206Service : IService<TABLE7206Dto, CreateTABLE7206Dto, UpdateTABLE7206Dto, int>
{
    Task<IEnumerable<TABLE7206Dto>> FindAsync(Expression<Func<TABLE7206, bool>> predicate);
}
