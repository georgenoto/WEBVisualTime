using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7038;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7038Service : IService<TABLE7038Dto, CreateTABLE7038Dto, UpdateTABLE7038Dto, int>
{
    Task<IEnumerable<TABLE7038Dto>> FindAsync(Expression<Func<TABLE7038, bool>> predicate);
}
