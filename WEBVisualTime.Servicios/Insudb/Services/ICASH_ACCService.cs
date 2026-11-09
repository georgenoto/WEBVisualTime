using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICASH_ACCService : IService<CASH_ACCDto, CreateCASH_ACCDto, UpdateCASH_ACCDto, string>
{
    Task<IEnumerable<CASH_ACCDto>> FindAsync(Expression<Func<CASH_ACC, bool>> predicate);
}
