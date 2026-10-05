using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7100;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7100Service : IService<TABLE7100Dto, CreateTABLE7100Dto, UpdateTABLE7100Dto, int>
{
    Task<IEnumerable<TABLE7100Dto>> FindAsync(Expression<Func<TABLE7100, bool>> predicate);
}
