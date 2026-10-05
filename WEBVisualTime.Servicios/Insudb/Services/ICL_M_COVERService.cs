using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_M_COVER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICL_M_COVERService : IService<CL_M_COVERDto, CreateCL_M_COVERDto, UpdateCL_M_COVERDto, long>
{
    Task<IEnumerable<CL_M_COVERDto>> FindAsync(Expression<Func<CL_M_COVER, bool>> predicate);
}
