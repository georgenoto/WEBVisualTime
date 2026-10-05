using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICL_COVERService : IService<CL_COVERDto, CreateCL_COVERDto, UpdateCL_COVERDto, long>
{
    Task<IEnumerable<CL_COVERDto>> FindAsync(Expression<Func<CL_COVER, bool>> predicate);
}
