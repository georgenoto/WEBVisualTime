using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCLAUS_CO_GService : IService<TCLAUS_CO_GDto, CreateTCLAUS_CO_GDto, UpdateTCLAUS_CO_GDto, string>
{
    Task<IEnumerable<TCLAUS_CO_GDto>> FindAsync(Expression<Func<TCLAUS_CO_G, bool>> predicate);
}
