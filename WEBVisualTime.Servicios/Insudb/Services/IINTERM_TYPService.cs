using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINTERM_TYPService : IService<INTERM_TYPDto, CreateINTERM_TYPDto, UpdateINTERM_TYPDto, int>
{
    Task<IEnumerable<INTERM_TYPDto>> FindAsync(Expression<Func<INTERM_TYP, bool>> predicate);
}
