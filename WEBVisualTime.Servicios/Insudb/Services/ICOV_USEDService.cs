using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOV_USEDService : IService<COV_USEDDto, CreateCOV_USEDDto, UpdateCOV_USEDDto, string>
{
    Task<IEnumerable<COV_USEDDto>> FindAsync(Expression<Func<COV_USED, bool>> predicate);
}
