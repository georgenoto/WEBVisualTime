using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROVISION_TYPEService : IService<PROVISION_TYPEDto, CreatePROVISION_TYPEDto, UpdatePROVISION_TYPEDto, int>
{
    Task<IEnumerable<PROVISION_TYPEDto>> FindAsync(Expression<Func<PROVISION_TYPE, bool>> predicate);
}
