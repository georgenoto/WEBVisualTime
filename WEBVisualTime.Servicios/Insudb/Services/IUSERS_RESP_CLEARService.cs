using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS_RESP_CLEAR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IUSERS_RESP_CLEARService : IService<USERS_RESP_CLEARDto, CreateUSERS_RESP_CLEARDto, UpdateUSERS_RESP_CLEARDto, int>
{
    Task<IEnumerable<USERS_RESP_CLEARDto>> FindAsync(Expression<Func<USERS_RESP_CLEAR, bool>> predicate);
}
