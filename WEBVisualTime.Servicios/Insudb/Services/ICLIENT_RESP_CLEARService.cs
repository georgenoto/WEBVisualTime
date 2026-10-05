using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_RESP_CLEAR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIENT_RESP_CLEARService : IService<CLIENT_RESP_CLEARDto, CreateCLIENT_RESP_CLEARDto, UpdateCLIENT_RESP_CLEARDto, string>
{
    Task<IEnumerable<CLIENT_RESP_CLEARDto>> FindAsync(Expression<Func<CLIENT_RESP_CLEAR, bool>> predicate);
}
