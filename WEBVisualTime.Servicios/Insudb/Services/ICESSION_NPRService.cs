using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_NPR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICESSION_NPRService : IService<CESSION_NPRDto, CreateCESSION_NPRDto, UpdateCESSION_NPRDto, long>
{
    Task<IEnumerable<CESSION_NPRDto>> FindAsync(Expression<Func<CESSION_NPR, bool>> predicate);
}
