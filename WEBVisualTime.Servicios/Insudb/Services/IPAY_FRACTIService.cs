using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_FRACTI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPAY_FRACTIService : IService<PAY_FRACTIDto, CreatePAY_FRACTIDto, UpdatePAY_FRACTIDto, string>
{
    Task<IEnumerable<PAY_FRACTIDto>> FindAsync(Expression<Func<PAY_FRACTI, bool>> predicate);
}
