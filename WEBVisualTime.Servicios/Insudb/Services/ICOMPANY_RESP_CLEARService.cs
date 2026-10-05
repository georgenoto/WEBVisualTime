using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY_RESP_CLEAR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMPANY_RESP_CLEARService : IService<COMPANY_RESP_CLEARDto, CreateCOMPANY_RESP_CLEARDto, UpdateCOMPANY_RESP_CLEARDto, int>
{
    Task<IEnumerable<COMPANY_RESP_CLEARDto>> FindAsync(Expression<Func<COMPANY_RESP_CLEAR, bool>> predicate);
}
