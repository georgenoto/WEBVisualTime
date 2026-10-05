using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REQ_ENDOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREQ_ENDORService : IService<REQ_ENDORDto, CreateREQ_ENDORDto, UpdateREQ_ENDORDto, long>
{
    Task<IEnumerable<REQ_ENDORDto>> FindAsync(Expression<Func<REQ_ENDOR, bool>> predicate);
}
