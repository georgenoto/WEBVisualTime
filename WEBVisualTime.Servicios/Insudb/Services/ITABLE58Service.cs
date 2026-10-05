using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE58;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE58Service : IService<TABLE58Dto, CreateTABLE58Dto, UpdateTABLE58Dto, int>
{
    Task<IEnumerable<TABLE58Dto>> FindAsync(Expression<Func<TABLE58, bool>> predicate);
}
