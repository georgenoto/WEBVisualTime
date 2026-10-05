using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TDETAIL_PRE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITDETAIL_PREService : IService<TDETAIL_PREDto, CreateTDETAIL_PREDto, UpdateTDETAIL_PREDto, string>
{
    Task<IEnumerable<TDETAIL_PREDto>> FindAsync(Expression<Func<TDETAIL_PRE, bool>> predicate);
}
