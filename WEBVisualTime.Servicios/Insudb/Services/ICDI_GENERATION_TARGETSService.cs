using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GENERATION_TARGETS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_GENERATION_TARGETSService : IService<CDI_GENERATION_TARGETSDto, CreateCDI_GENERATION_TARGETSDto, UpdateCDI_GENERATION_TARGETSDto, string>
{
    Task<IEnumerable<CDI_GENERATION_TARGETSDto>> FindAsync(Expression<Func<CDI_GENERATION_TARGETS, bool>> predicate);
}
