using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE307;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE307Service : IService<TABLE307Dto, CreateTABLE307Dto, UpdateTABLE307Dto, long>
{
    Task<IEnumerable<TABLE307Dto>> FindAsync(Expression<Func<TABLE307, bool>> predicate);
}
