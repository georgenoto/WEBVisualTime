using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CODE_SECTION_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_CODE_SECTION_TYPESService : IService<CDI_CODE_SECTION_TYPESDto, CreateCDI_CODE_SECTION_TYPESDto, UpdateCDI_CODE_SECTION_TYPESDto, string>
{
    Task<IEnumerable<CDI_CODE_SECTION_TYPESDto>> FindAsync(Expression<Func<CDI_CODE_SECTION_TYPES, bool>> predicate);
}
