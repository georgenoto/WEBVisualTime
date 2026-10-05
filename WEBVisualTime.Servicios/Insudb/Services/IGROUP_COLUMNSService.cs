using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUP_COLUMNS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IGROUP_COLUMNSService : IService<GROUP_COLUMNSDto, CreateGROUP_COLUMNSDto, UpdateGROUP_COLUMNSDto, int>
{
    Task<IEnumerable<GROUP_COLUMNSDto>> FindAsync(Expression<Func<GROUP_COLUMNS, bool>> predicate);
}
