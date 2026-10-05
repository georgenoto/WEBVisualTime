using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISTATUS_CLAIMService : IService<STATUS_CLAIMDto, CreateSTATUS_CLAIMDto, UpdateSTATUS_CLAIMDto, int>
{
    Task<IEnumerable<STATUS_CLAIMDto>> FindAsync(Expression<Func<STATUS_CLAIM, bool>> predicate);
}
