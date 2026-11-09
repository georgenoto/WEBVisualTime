using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_PRE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFINANC_PREService : IService<FINANC_PREDto, CreateFINANC_PREDto, UpdateFINANC_PREDto, string>
{
    Task<IEnumerable<FINANC_PREDto>> FindAsync(Expression<Func<FINANC_PRE, bool>> predicate);
}
