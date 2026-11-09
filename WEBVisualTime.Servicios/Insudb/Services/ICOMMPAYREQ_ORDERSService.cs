using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMPAYREQ_ORDERSService : IService<COMMPAYREQ_ORDERSDto, CreateCOMMPAYREQ_ORDERSDto, UpdateCOMMPAYREQ_ORDERSDto, string>
{
    Task<IEnumerable<COMMPAYREQ_ORDERSDto>> FindAsync(Expression<Func<COMMPAYREQ_ORDERS, bool>> predicate);
}
