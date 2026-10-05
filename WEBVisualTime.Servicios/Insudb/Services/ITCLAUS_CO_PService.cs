using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_P;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCLAUS_CO_PService : IService<TCLAUS_CO_PDto, CreateTCLAUS_CO_PDto, UpdateTCLAUS_CO_PDto, string>
{
    Task<IEnumerable<TCLAUS_CO_PDto>> FindAsync(Expression<Func<TCLAUS_CO_P, bool>> predicate);
}
