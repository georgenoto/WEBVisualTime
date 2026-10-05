using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_JOB;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBATCH_JOBService : IService<BATCH_JOBDto, CreateBATCH_JOBDto, UpdateBATCH_JOBDto, string>
{
    Task<IEnumerable<BATCH_JOBDto>> FindAsync(Expression<Func<BATCH_JOB, bool>> predicate);
}
