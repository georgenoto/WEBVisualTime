using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTRMASTERService : IService<CONTRMASTERDto, CreateCONTRMASTERDto, UpdateCONTRMASTERDto, string>
{
    Task<IEnumerable<CONTRMASTERDto>> FindAsync(Expression<Func<CONTRMASTER, bool>> predicate);
}
