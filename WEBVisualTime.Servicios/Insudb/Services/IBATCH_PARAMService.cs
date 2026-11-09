using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBATCH_PARAMService : IService<BATCH_PARAMDto, CreateBATCH_PARAMDto, UpdateBATCH_PARAMDto, string>
{
    Task<IEnumerable<BATCH_PARAMDto>> FindAsync(Expression<Func<BATCH_PARAM, bool>> predicate);
}
