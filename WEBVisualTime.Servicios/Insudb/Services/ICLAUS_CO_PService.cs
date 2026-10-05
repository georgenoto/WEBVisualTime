using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUS_CO_P;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAUS_CO_PService : IService<CLAUS_CO_PDto, CreateCLAUS_CO_PDto, UpdateCLAUS_CO_PDto, string>
{
    Task<IEnumerable<CLAUS_CO_PDto>> FindAsync(Expression<Func<CLAUS_CO_P, bool>> predicate);
}
