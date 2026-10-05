using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHARG_PREBASPAY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICHARG_PREBASPAYService : IService<CHARG_PREBASPAYDto, CreateCHARG_PREBASPAYDto, UpdateCHARG_PREBASPAYDto, int>
{
    Task<IEnumerable<CHARG_PREBASPAYDto>> FindAsync(Expression<Func<CHARG_PREBASPAY, bool>> predicate);
}
