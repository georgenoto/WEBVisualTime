using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_PARAM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINTERM_PARAMService : IService<INTERM_PARAMDto, CreateINTERM_PARAMDto, UpdateINTERM_PARAMDto, decimal>
{
    Task<IEnumerable<INTERM_PARAMDto>> FindAsync(Expression<Func<INTERM_PARAM, bool>> predicate);
}
