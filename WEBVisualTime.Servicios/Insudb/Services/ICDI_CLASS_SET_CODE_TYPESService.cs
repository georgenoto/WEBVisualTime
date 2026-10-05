using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CLASS_SET_CODE_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_CLASS_SET_CODE_TYPESService : IService<CDI_CLASS_SET_CODE_TYPESDto, CreateCDI_CLASS_SET_CODE_TYPESDto, UpdateCDI_CLASS_SET_CODE_TYPESDto, string>
{
    Task<IEnumerable<CDI_CLASS_SET_CODE_TYPESDto>> FindAsync(Expression<Func<CDI_CLASS_SET_CODE_TYPES, bool>> predicate);
}
