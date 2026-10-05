using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVERCOL_TMP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVERCOL_TMPService : IService<COVERCOL_TMPDto, CreateCOVERCOL_TMPDto, UpdateCOVERCOL_TMPDto, string>
{
    Task<IEnumerable<COVERCOL_TMPDto>> FindAsync(Expression<Func<COVERCOL_TMP, bool>> predicate);
}
