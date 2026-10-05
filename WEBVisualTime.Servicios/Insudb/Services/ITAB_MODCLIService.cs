using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODCLI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MODCLIService : IService<TAB_MODCLIDto, CreateTAB_MODCLIDto, UpdateTAB_MODCLIDto, string>
{
    Task<IEnumerable<TAB_MODCLIDto>> FindAsync(Expression<Func<TAB_MODCLI, bool>> predicate);
}
