using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_RULES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASSIVE_RULESService : IService<MASSIVE_RULESDto, CreateMASSIVE_RULESDto, UpdateMASSIVE_RULESDto, long>
{
    Task<IEnumerable<MASSIVE_RULESDto>> FindAsync(Expression<Func<MASSIVE_RULES, bool>> predicate);
}
