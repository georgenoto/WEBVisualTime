using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM_VALUE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBATCH_PARAM_VALUEService : IService<BATCH_PARAM_VALUEDto, CreateBATCH_PARAM_VALUEDto, UpdateBATCH_PARAM_VALUEDto, string>
{
    Task<IEnumerable<BATCH_PARAM_VALUEDto>> FindAsync(Expression<Func<BATCH_PARAM_VALUE, bool>> predicate);
}
