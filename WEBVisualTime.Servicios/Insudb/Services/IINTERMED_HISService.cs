using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINTERMED_HISService : IService<INTERMED_HISDto, CreateINTERMED_HISDto, UpdateINTERMED_HISDto, string>
{
    Task<IEnumerable<INTERMED_HISDto>> FindAsync(Expression<Func<INTERMED_HIS, bool>> predicate);
}
