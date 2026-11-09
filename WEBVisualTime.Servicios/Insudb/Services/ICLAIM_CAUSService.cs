using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CAUS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_CAUSService : IService<CLAIM_CAUSDto, CreateCLAIM_CAUSDto, UpdateCLAIM_CAUSDto, string>
{
    Task<IEnumerable<CLAIM_CAUSDto>> FindAsync(Expression<Func<CLAIM_CAUS, bool>> predicate);
}
