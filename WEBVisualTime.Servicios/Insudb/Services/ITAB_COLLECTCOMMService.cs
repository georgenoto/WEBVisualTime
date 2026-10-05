using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_COLLECTCOMMService : IService<TAB_COLLECTCOMMDto, CreateTAB_COLLECTCOMMDto, UpdateTAB_COLLECTCOMMDto, int>
{
    Task<IEnumerable<TAB_COLLECTCOMMDto>> FindAsync(Expression<Func<TAB_COLLECTCOMM, bool>> predicate);
}
