using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_NET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPL_ASP_NETService : IService<PL_ASP_NETDto, CreatePL_ASP_NETDto, UpdatePL_ASP_NETDto, int>
{
    Task<IEnumerable<PL_ASP_NETDto>> FindAsync(Expression<Func<PL_ASP_NET, bool>> predicate);
}
