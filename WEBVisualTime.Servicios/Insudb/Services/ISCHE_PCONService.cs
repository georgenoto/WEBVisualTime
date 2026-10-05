using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_PCON;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_PCONService : IService<SCHE_PCONDto, CreateSCHE_PCONDto, UpdateSCHE_PCONDto, string>
{
    Task<IEnumerable<SCHE_PCONDto>> FindAsync(Expression<Func<SCHE_PCON, bool>> predicate);
}
