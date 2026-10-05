using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_MASTER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_MASTERService : IService<CLAIM_MASTERDto, CreateCLAIM_MASTERDto, UpdateCLAIM_MASTERDto, long>
{
    Task<IEnumerable<CLAIM_MASTERDto>> FindAsync(Expression<Func<CLAIM_MASTER, bool>> predicate);
}
