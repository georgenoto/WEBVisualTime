using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE203Service : IService<TABLE203Dto, CreateTABLE203Dto, UpdateTABLE203Dto, int>
{
    Task<IEnumerable<TABLE203Dto>> FindAsync(Expression<Func<TABLE203, bool>> predicate);
}
