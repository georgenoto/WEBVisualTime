using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_TRANSAC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_TRANSACService : IService<SCHE_TRANSACDto, CreateSCHE_TRANSACDto, UpdateSCHE_TRANSACDto, string>
{
    Task<IEnumerable<SCHE_TRANSACDto>> FindAsync(Expression<Func<SCHE_TRANSAC, bool>> predicate);
}
