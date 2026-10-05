using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_LANGUAGE_DEFINITIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_LANGUAGE_DEFINITIONSService : IService<CDI_LANGUAGE_DEFINITIONSDto, CreateCDI_LANGUAGE_DEFINITIONSDto, UpdateCDI_LANGUAGE_DEFINITIONSDto, long>
{
    Task<IEnumerable<CDI_LANGUAGE_DEFINITIONSDto>> FindAsync(Expression<Func<CDI_LANGUAGE_DEFINITIONS, bool>> predicate);
}
