using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECTION_PO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISECTION_POService : IService<SECTION_PODto, CreateSECTION_PODto, UpdateSECTION_PODto, int>
{
    Task<IEnumerable<SECTION_PODto>> FindAsync(Expression<Func<SECTION_PO, bool>> predicate);
}
