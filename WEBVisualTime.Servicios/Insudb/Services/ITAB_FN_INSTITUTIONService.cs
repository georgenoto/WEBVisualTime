using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FN_INSTITUTION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_FN_INSTITUTIONService : IService<TAB_FN_INSTITUTIONDto, CreateTAB_FN_INSTITUTIONDto, UpdateTAB_FN_INSTITUTIONDto, int>
{
    Task<IEnumerable<TAB_FN_INSTITUTIONDto>> FindAsync(Expression<Func<TAB_FN_INSTITUTION, bool>> predicate);
}
