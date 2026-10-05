using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_CASHNUM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IUSER_CASHNUMService : IService<USER_CASHNUMDto, CreateUSER_CASHNUMDto, UpdateUSER_CASHNUMDto, int>
{
    Task<IEnumerable<USER_CASHNUMDto>> FindAsync(Expression<Func<USER_CASHNUM, bool>> predicate);
}
