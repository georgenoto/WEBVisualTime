using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REFINAN_DRA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREFINAN_DRAService : IService<REFINAN_DRADto, CreateREFINAN_DRADto, UpdateREFINAN_DRADto, long>
{
    Task<IEnumerable<REFINAN_DRADto>> FindAsync(Expression<Func<REFINAN_DRA, bool>> predicate);
}
