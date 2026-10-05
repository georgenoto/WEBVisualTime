using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DEVLOCALRECORDSDELETED;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDEVLOCALRECORDSDELETEDService : IService<DEVLOCALRECORDSDELETEDDto, CreateDEVLOCALRECORDSDELETEDDto, UpdateDEVLOCALRECORDSDELETEDDto, int>
{
    Task<IEnumerable<DEVLOCALRECORDSDELETEDDto>> FindAsync(Expression<Func<DEVLOCALRECORDSDELETED, bool>> predicate);
}
