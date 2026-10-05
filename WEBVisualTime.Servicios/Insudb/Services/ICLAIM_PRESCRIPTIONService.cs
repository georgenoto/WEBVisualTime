using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_PRESCRIPTION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIM_PRESCRIPTIONService : IService<CLAIM_PRESCRIPTIONDto, CreateCLAIM_PRESCRIPTIONDto, UpdateCLAIM_PRESCRIPTIONDto, int>
{
    Task<IEnumerable<CLAIM_PRESCRIPTIONDto>> FindAsync(Expression<Func<CLAIM_PRESCRIPTION, bool>> predicate);
}
