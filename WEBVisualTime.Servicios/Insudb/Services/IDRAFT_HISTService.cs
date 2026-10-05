using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DRAFT_HIST;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDRAFT_HISTService : IService<DRAFT_HISTDto, CreateDRAFT_HISTDto, UpdateDRAFT_HISTDto, long>
{
    Task<IEnumerable<DRAFT_HISTDto>> FindAsync(Expression<Func<DRAFT_HIST, bool>> predicate);
}
