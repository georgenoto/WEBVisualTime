using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCEPTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICASH_CONCEPTSService : IService<CASH_CONCEPTSDto, CreateCASH_CONCEPTSDto, UpdateCASH_CONCEPTSDto, string>
{
    Task<IEnumerable<CASH_CONCEPTSDto>> FindAsync(Expression<Func<CASH_CONCEPTS, bool>> predicate);
}
