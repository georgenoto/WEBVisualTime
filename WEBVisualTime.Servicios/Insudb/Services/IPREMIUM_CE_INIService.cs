using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_CE_INI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPREMIUM_CE_INIService : IService<PREMIUM_CE_INIDto, CreatePREMIUM_CE_INIDto, UpdatePREMIUM_CE_INIDto, string>
{
    Task<IEnumerable<PREMIUM_CE_INIDto>> FindAsync(Expression<Func<PREMIUM_CE_INI, bool>> predicate);
}
