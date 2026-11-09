using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMIS_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMIS_HISService : IService<COMMIS_HISDto, CreateCOMMIS_HISDto, UpdateCOMMIS_HISDto, string>
{
    Task<IEnumerable<COMMIS_HISDto>> FindAsync(Expression<Func<COMMIS_HIS, bool>> predicate);
}
