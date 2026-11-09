using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DETAIL_PRE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDETAIL_PREService : IService<DETAIL_PREDto, CreateDETAIL_PREDto, UpdateDETAIL_PREDto, string>
{
    Task<IEnumerable<DETAIL_PREDto>> FindAsync(Expression<Func<DETAIL_PRE, bool>> predicate);
}
