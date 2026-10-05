using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_PROC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASSIVE_LOG_PROCService : IService<MASSIVE_LOG_PROCDto, CreateMASSIVE_LOG_PROCDto, UpdateMASSIVE_LOG_PROCDto, string>
{
    Task<IEnumerable<MASSIVE_LOG_PROCDto>> FindAsync(Expression<Func<MASSIVE_LOG_PROC, bool>> predicate);
}
