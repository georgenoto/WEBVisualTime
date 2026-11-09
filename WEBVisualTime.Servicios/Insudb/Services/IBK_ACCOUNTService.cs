using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BK_ACCOUNT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBK_ACCOUNTService : IService<BK_ACCOUNTDto, CreateBK_ACCOUNTDto, UpdateBK_ACCOUNTDto, string>
{
    Task<IEnumerable<BK_ACCOUNTDto>> FindAsync(Expression<Func<BK_ACCOUNT, bool>> predicate);
}
