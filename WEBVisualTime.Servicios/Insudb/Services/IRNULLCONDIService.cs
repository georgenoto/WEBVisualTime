using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RNULLCONDI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRNULLCONDIService : IService<RNULLCONDIDto, CreateRNULLCONDIDto, UpdateRNULLCONDIDto, string>
{
    Task<IEnumerable<RNULLCONDIDto>> FindAsync(Expression<Func<RNULLCONDI, bool>> predicate);
}
