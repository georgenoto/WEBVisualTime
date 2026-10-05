using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_CE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPREMIUM_CEService : IService<PREMIUM_CEDto, CreatePREMIUM_CEDto, UpdatePREMIUM_CEDto, string>
{
    Task<IEnumerable<PREMIUM_CEDto>> FindAsync(Expression<Func<PREMIUM_CE, bool>> predicate);
}
