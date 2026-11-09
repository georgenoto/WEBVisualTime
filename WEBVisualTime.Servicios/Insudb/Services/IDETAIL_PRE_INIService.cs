using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DETAIL_PRE_INI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDETAIL_PRE_INIService : IService<DETAIL_PRE_INIDto, CreateDETAIL_PRE_INIDto, UpdateDETAIL_PRE_INIDto, string>
{
    Task<IEnumerable<DETAIL_PRE_INIDto>> FindAsync(Expression<Func<DETAIL_PRE_INI, bool>> predicate);
}
