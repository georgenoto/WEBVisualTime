using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRM_LINK_CUSTOMIZED_QUERYService : IService<RM_LINK_CUSTOMIZED_QUERYDto, CreateRM_LINK_CUSTOMIZED_QUERYDto, UpdateRM_LINK_CUSTOMIZED_QUERYDto, string>
{
    Task<IEnumerable<RM_LINK_CUSTOMIZED_QUERYDto>> FindAsync(Expression<Func<RM_LINK_CUSTOMIZED_QUERY, bool>> predicate);
}
