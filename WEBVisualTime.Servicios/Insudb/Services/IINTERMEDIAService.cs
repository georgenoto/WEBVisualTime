using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINTERMEDIAService : IService<INTERMEDIADto, CreateINTERMEDIADto, UpdateINTERMEDIADto, long>
{
    Task<IEnumerable<INTERMEDIADto>> FindAsync(Expression<Func<INTERMEDIA, bool>> predicate);
}
