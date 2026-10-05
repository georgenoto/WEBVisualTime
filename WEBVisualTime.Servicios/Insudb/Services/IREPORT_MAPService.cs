using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_MAP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREPORT_MAPService : IService<REPORT_MAPDto, CreateREPORT_MAPDto, UpdateREPORT_MAPDto, int>
{
    Task<IEnumerable<REPORT_MAPDto>> FindAsync(Expression<Func<REPORT_MAP, bool>> predicate);
}
