using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DSEX_CONDI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDSEX_CONDIService : IService<DSEX_CONDIDto, CreateDSEX_CONDIDto, UpdateDSEX_CONDIDto, int>
{
    Task<IEnumerable<DSEX_CONDIDto>> FindAsync(Expression<Func<DSEX_CONDI, bool>> predicate);
}
