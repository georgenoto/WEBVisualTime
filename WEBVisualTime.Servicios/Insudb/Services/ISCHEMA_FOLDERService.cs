using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_FOLDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHEMA_FOLDERService : IService<SCHEMA_FOLDERDto, CreateSCHEMA_FOLDERDto, UpdateSCHEMA_FOLDERDto, string>
{
    Task<IEnumerable<SCHEMA_FOLDERDto>> FindAsync(Expression<Func<SCHEMA_FOLDER, bool>> predicate);
}
