using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_REG_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRM_REG_TYPESService : IService<RM_REG_TYPESDto, CreateRM_REG_TYPESDto, UpdateRM_REG_TYPESDto, string>
{
    Task<IEnumerable<RM_REG_TYPESDto>> FindAsync(Expression<Func<RM_REG_TYPES, bool>> predicate);
}
