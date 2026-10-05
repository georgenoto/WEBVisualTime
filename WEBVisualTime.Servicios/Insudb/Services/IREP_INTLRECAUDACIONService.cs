using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_INTLRECAUDACION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREP_INTLRECAUDACIONService : IService<REP_INTLRECAUDACIONDto, CreateREP_INTLRECAUDACIONDto, UpdateREP_INTLRECAUDACIONDto, string>
{
    Task<IEnumerable<REP_INTLRECAUDACIONDto>> FindAsync(Expression<Func<REP_INTLRECAUDACION, bool>> predicate);
}
