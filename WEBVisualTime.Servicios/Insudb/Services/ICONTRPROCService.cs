using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRPROC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTRPROCService : IService<CONTRPROCDto, CreateCONTRPROCDto, UpdateCONTRPROCDto, int>
{
    Task<IEnumerable<CONTRPROCDto>> FindAsync(Expression<Func<CONTRPROC, bool>> predicate);
}
