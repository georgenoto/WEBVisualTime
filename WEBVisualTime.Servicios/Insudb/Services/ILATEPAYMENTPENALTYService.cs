using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LATEPAYMENTPENALTY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILATEPAYMENTPENALTYService : IService<LATEPAYMENTPENALTYDto, CreateLATEPAYMENTPENALTYDto, UpdateLATEPAYMENTPENALTYDto, string>
{
    Task<IEnumerable<LATEPAYMENTPENALTYDto>> FindAsync(Expression<Func<LATEPAYMENTPENALTY, bool>> predicate);
}
