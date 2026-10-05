using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_PARTIC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINTERMED_PARTICService : IService<INTERMED_PARTICDto, CreateINTERMED_PARTICDto, UpdateINTERMED_PARTICDto, long>
{
    Task<IEnumerable<INTERMED_PARTICDto>> FindAsync(Expression<Func<INTERMED_PARTIC, bool>> predicate);
}
