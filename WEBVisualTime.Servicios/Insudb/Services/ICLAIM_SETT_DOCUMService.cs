using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_DOCUM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_SETT_DOCUMService : IService<CLAIM_SETT_DOCUMDto, CreateCLAIM_SETT_DOCUMDto, UpdateCLAIM_SETT_DOCUMDto, string>
{
    Task<IEnumerable<CLAIM_SETT_DOCUMDto>> FindAsync(Expression<Func<CLAIM_SETT_DOCUM, bool>> predicate);
}
