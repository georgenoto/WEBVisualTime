using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP_BKP20260910;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_DOCTYP_BKP20260910Service : IService<T_DOCTYP_BKP20260910Dto, CreateT_DOCTYP_BKP20260910Dto, UpdateT_DOCTYP_BKP20260910Dto, string>
{
    Task<IEnumerable<T_DOCTYP_BKP20260910Dto>> FindAsync(Expression<Func<T_DOCTYP_BKP20260910, bool>> predicate);
}
