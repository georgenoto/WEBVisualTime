using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CALEND_INTERFACE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICALEND_INTERFACEService : IService<CALEND_INTERFACEDto, CreateCALEND_INTERFACEDto, UpdateCALEND_INTERFACEDto, int>
{
    Task<IEnumerable<CALEND_INTERFACEDto>> FindAsync(Expression<Func<CALEND_INTERFACE, bool>> predicate);
}
