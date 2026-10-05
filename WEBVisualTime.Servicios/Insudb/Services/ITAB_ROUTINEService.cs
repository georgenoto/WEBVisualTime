using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_ROUTINE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_ROUTINEService : IService<TAB_ROUTINEDto, CreateTAB_ROUTINEDto, UpdateTAB_ROUTINEDto, string>
{
    Task<IEnumerable<TAB_ROUTINEDto>> FindAsync(Expression<Func<TAB_ROUTINE, bool>> predicate);
}
