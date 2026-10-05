using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_CO_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMODUL_CO_GService : IService<MODUL_CO_GDto, CreateMODUL_CO_GDto, UpdateMODUL_CO_GDto, string>
{
    Task<IEnumerable<MODUL_CO_GDto>> FindAsync(Expression<Func<MODUL_CO_G, bool>> predicate);
}
