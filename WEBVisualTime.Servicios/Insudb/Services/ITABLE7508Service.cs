using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7508;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7508Service : IService<TABLE7508Dto, CreateTABLE7508Dto, UpdateTABLE7508Dto, int>
{
    Task<IEnumerable<TABLE7508Dto>> FindAsync(Expression<Func<TABLE7508, bool>> predicate);
}
