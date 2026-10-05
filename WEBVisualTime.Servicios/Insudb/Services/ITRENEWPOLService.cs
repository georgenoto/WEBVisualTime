using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRENEWPOL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITRENEWPOLService : IService<TRENEWPOLDto, CreateTRENEWPOLDto, UpdateTRENEWPOLDto, string>
{
    Task<IEnumerable<TRENEWPOLDto>> FindAsync(Expression<Func<TRENEWPOL, bool>> predicate);
}
