using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PREF_DOMAINS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_PREF_DOMAINSService : IService<CDI_PREF_DOMAINSDto, CreateCDI_PREF_DOMAINSDto, UpdateCDI_PREF_DOMAINSDto, string>
{
    Task<IEnumerable<CDI_PREF_DOMAINSDto>> FindAsync(Expression<Func<CDI_PREF_DOMAINS, bool>> predicate);
}
