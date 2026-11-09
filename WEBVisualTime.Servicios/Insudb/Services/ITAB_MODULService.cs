using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODUL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MODULService : IService<TAB_MODULDto, CreateTAB_MODULDto, UpdateTAB_MODULDto, string>
{
    Task<IEnumerable<TAB_MODULDto>> FindAsync(Expression<Func<TAB_MODUL, bool>> predicate);
}
