using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7205;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7205Service : IService<TABLE7205Dto, CreateTABLE7205Dto, UpdateTABLE7205Dto, int>
{
    Task<IEnumerable<TABLE7205Dto>> FindAsync(Expression<Func<TABLE7205, bool>> predicate);
}
