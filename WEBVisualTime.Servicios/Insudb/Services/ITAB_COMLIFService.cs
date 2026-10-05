using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMLIF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_COMLIFService : IService<TAB_COMLIFDto, CreateTAB_COMLIFDto, UpdateTAB_COMLIFDto, int>
{
    Task<IEnumerable<TAB_COMLIFDto>> FindAsync(Expression<Func<TAB_COMLIF, bool>> predicate);
}
