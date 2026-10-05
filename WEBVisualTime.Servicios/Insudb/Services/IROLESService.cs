using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IROLESService : IService<ROLESDto, CreateROLESDto, UpdateROLESDto, string>
{
    Task<IEnumerable<ROLESDto>> FindAsync(Expression<Func<ROLES, bool>> predicate);
}
