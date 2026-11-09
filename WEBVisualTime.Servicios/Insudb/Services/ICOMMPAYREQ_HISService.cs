using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMPAYREQ_HISService : IService<COMMPAYREQ_HISDto, CreateCOMMPAYREQ_HISDto, UpdateCOMMPAYREQ_HISDto, string>
{
    Task<IEnumerable<COMMPAYREQ_HISDto>> FindAsync(Expression<Func<COMMPAYREQ_HIS, bool>> predicate);
}
