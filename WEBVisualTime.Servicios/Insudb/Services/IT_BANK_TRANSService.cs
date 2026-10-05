using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_TRANS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_BANK_TRANSService : IService<T_BANK_TRANSDto, CreateT_BANK_TRANSDto, UpdateT_BANK_TRANSDto, long>
{
    Task<IEnumerable<T_BANK_TRANSDto>> FindAsync(Expression<Func<T_BANK_TRANS, bool>> predicate);
}
