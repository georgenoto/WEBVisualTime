using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLE_TYPE_AMEND;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IROLE_TYPE_AMENDService : IService<ROLE_TYPE_AMENDDto, CreateROLE_TYPE_AMENDDto, UpdateROLE_TYPE_AMENDDto, int>
{
    Task<IEnumerable<ROLE_TYPE_AMENDDto>> FindAsync(Expression<Func<ROLE_TYPE_AMEND, bool>> predicate);
}
