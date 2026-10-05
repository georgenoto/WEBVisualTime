using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_CLASICO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPL_ASP_CLASICOService : IService<PL_ASP_CLASICODto, CreatePL_ASP_CLASICODto, UpdatePL_ASP_CLASICODto, int>
{
    Task<IEnumerable<PL_ASP_CLASICODto>> FindAsync(Expression<Func<PL_ASP_CLASICO, bool>> predicate);
}
