using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECTCAUSE_PRECLAIM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREJECTCAUSE_PRECLAIMService : IService<REJECTCAUSE_PRECLAIMDto, CreateREJECTCAUSE_PRECLAIMDto, UpdateREJECTCAUSE_PRECLAIMDto, string>
{
    Task<IEnumerable<REJECTCAUSE_PRECLAIMDto>> FindAsync(Expression<Func<REJECTCAUSE_PRECLAIM, bool>> predicate);
}
