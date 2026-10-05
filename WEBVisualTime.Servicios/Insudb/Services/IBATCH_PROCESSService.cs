using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PROCESS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBATCH_PROCESSService : IService<BATCH_PROCESSDto, CreateBATCH_PROCESSDto, UpdateBATCH_PROCESSDto, int>
{
    Task<IEnumerable<BATCH_PROCESSDto>> FindAsync(Expression<Func<BATCH_PROCESS, bool>> predicate);
}
