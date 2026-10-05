using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_ERROR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASSIVE_LOG_ERRORService : IService<MASSIVE_LOG_ERRORDto, CreateMASSIVE_LOG_ERRORDto, UpdateMASSIVE_LOG_ERRORDto, string>
{
    Task<IEnumerable<MASSIVE_LOG_ERRORDto>> FindAsync(Expression<Func<MASSIVE_LOG_ERROR, bool>> predicate);
}
