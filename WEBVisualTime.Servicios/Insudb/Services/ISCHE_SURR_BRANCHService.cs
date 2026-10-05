using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_BRANCH;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_SURR_BRANCHService : IService<SCHE_SURR_BRANCHDto, CreateSCHE_SURR_BRANCHDto, UpdateSCHE_SURR_BRANCHDto, string>
{
    Task<IEnumerable<SCHE_SURR_BRANCHDto>> FindAsync(Expression<Func<SCHE_SURR_BRANCH, bool>> predicate);
}
