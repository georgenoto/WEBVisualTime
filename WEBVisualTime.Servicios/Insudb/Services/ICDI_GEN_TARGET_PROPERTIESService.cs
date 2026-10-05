using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GEN_TARGET_PROPERTIES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_GEN_TARGET_PROPERTIESService : IService<CDI_GEN_TARGET_PROPERTIESDto, CreateCDI_GEN_TARGET_PROPERTIESDto, UpdateCDI_GEN_TARGET_PROPERTIESDto, string>
{
    Task<IEnumerable<CDI_GEN_TARGET_PROPERTIESDto>> FindAsync(Expression<Func<CDI_GEN_TARGET_PROPERTIES, bool>> predicate);
}
