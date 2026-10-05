using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY_BIND;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRM_LINK_CUSTOMIZED_QUERY_BINDService : IService<RM_LINK_CUSTOMIZED_QUERY_BINDDto, CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto, UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto, string>
{
    Task<IEnumerable<RM_LINK_CUSTOMIZED_QUERY_BINDDto>> FindAsync(Expression<Func<RM_LINK_CUSTOMIZED_QUERY_BIND, bool>> predicate);
}
