using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_CO_P;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMODUL_CO_PService : IService<MODUL_CO_PDto, CreateMODUL_CO_PDto, UpdateMODUL_CO_PDto, string>
{
    Task<IEnumerable<MODUL_CO_PDto>> FindAsync(Expression<Func<MODUL_CO_P, bool>> predicate);
}
