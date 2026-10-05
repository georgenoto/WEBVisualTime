using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7200;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7200Service : IService<TABLE7200Dto, CreateTABLE7200Dto, UpdateTABLE7200Dto, int>
{
    Task<IEnumerable<TABLE7200Dto>> FindAsync(Expression<Func<TABLE7200, bool>> predicate);
}
