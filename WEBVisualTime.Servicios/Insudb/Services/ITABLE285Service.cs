using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE285;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE285Service : IService<TABLE285Dto, CreateTABLE285Dto, UpdateTABLE285Dto, long>
{
    Task<IEnumerable<TABLE285Dto>> FindAsync(Expression<Func<TABLE285, bool>> predicate);
}
