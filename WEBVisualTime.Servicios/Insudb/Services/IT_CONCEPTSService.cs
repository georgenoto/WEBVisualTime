using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CONCEPTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_CONCEPTSService : IService<T_CONCEPTSDto, CreateT_CONCEPTSDto, UpdateT_CONCEPTSDto, long>
{
    Task<IEnumerable<T_CONCEPTSDto>> FindAsync(Expression<Func<T_CONCEPTS, bool>> predicate);
}
