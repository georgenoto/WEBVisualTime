using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISDD_DEPENDENCY_TYPESService : IService<SDD_DEPENDENCY_TYPESDto, CreateSDD_DEPENDENCY_TYPESDto, UpdateSDD_DEPENDENCY_TYPESDto, int>
{
    Task<IEnumerable<SDD_DEPENDENCY_TYPESDto>> FindAsync(Expression<Func<SDD_DEPENDENCY_TYPES, bool>> predicate);
}
