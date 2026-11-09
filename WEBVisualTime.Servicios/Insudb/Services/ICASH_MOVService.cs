using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_MOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICASH_MOVService : IService<CASH_MOVDto, CreateCASH_MOVDto, UpdateCASH_MOVDto, string>
{
    Task<IEnumerable<CASH_MOVDto>> FindAsync(Expression<Func<CASH_MOV, bool>> predicate);
}
