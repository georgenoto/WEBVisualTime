using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_EVALRISK;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_EVALRISKService : IService<CLIENT_EVALRISKDto, CreateCLIENT_EVALRISKDto, UpdateCLIENT_EVALRISKDto, string>
{
    Task<IEnumerable<CLIENT_EVALRISKDto>> FindAsync(Expression<Func<CLIENT_EVALRISK, bool>> predicate);
}
