using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DISCO_EXPR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDISCO_EXPRService : IService<DISCO_EXPRDto, CreateDISCO_EXPRDto, UpdateDISCO_EXPRDto, string>
{
    Task<IEnumerable<DISCO_EXPRDto>> FindAsync(Expression<Func<DISCO_EXPR, bool>> predicate);
}
