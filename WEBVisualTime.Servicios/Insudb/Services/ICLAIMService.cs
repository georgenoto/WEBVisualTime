using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIMService : IService<CLAIMDto, CreateCLAIMDto, UpdateCLAIMDto, long>
{
    Task<IEnumerable<CLAIMDto>> FindAsync(Expression<Func<CLAIM, bool>> predicate);
}
