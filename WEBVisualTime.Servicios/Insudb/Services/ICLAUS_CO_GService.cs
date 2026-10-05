using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUS_CO_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAUS_CO_GService : IService<CLAUS_CO_GDto, CreateCLAUS_CO_GDto, UpdateCLAUS_CO_GDto, string>
{
    Task<IEnumerable<CLAUS_CO_GDto>> FindAsync(Expression<Func<CLAUS_CO_G, bool>> predicate);
}
