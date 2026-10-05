using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPIE_ELEMENT_TYPESService : IService<PIE_ELEMENT_TYPESDto, CreatePIE_ELEMENT_TYPESDto, UpdatePIE_ELEMENT_TYPESDto, string>
{
    Task<IEnumerable<PIE_ELEMENT_TYPESDto>> FindAsync(Expression<Func<PIE_ELEMENT_TYPES, bool>> predicate);
}
