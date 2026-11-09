using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_POLICIES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMPAYREQ_POLICIESService : IService<COMMPAYREQ_POLICIESDto, CreateCOMMPAYREQ_POLICIESDto, UpdateCOMMPAYREQ_POLICIESDto, string>
{
    Task<IEnumerable<COMMPAYREQ_POLICIESDto>> FindAsync(Expression<Func<COMMPAYREQ_POLICIES, bool>> predicate);
}
