using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_ORD_CONCEPTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPAY_ORD_CONCEPTSService : IService<PAY_ORD_CONCEPTSDto, CreatePAY_ORD_CONCEPTSDto, UpdatePAY_ORD_CONCEPTSDto, int>
{
    Task<IEnumerable<PAY_ORD_CONCEPTSDto>> FindAsync(Expression<Func<PAY_ORD_CONCEPTS, bool>> predicate);
}
