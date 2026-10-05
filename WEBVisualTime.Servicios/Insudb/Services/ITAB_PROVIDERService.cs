using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_PROVIDERService : IService<TAB_PROVIDERDto, CreateTAB_PROVIDERDto, UpdateTAB_PROVIDERDto, int>
{
    Task<IEnumerable<TAB_PROVIDERDto>> FindAsync(Expression<Func<TAB_PROVIDER, bool>> predicate);
}
