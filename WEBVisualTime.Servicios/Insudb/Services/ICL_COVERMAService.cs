using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVERMA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICL_COVERMAService : IService<CL_COVERMADto, CreateCL_COVERMADto, UpdateCL_COVERMADto, string>
{
    Task<IEnumerable<CL_COVERMADto>> FindAsync(Expression<Func<CL_COVERMA, bool>> predicate);
}
