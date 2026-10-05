using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_RESERVED_NAMES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISDD_RESERVED_NAMESService : IService<SDD_RESERVED_NAMESDto, CreateSDD_RESERVED_NAMESDto, UpdateSDD_RESERVED_NAMESDto, string>
{
    Task<IEnumerable<SDD_RESERVED_NAMESDto>> FindAsync(Expression<Func<SDD_RESERVED_NAMES, bool>> predicate);
}
