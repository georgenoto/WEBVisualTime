using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDBENEFITS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MEDBENEFITSService : IService<TAB_MEDBENEFITSDto, CreateTAB_MEDBENEFITSDto, UpdateTAB_MEDBENEFITSDto, string>
{
    Task<IEnumerable<TAB_MEDBENEFITSDto>> FindAsync(Expression<Func<TAB_MEDBENEFITS, bool>> predicate);
}
