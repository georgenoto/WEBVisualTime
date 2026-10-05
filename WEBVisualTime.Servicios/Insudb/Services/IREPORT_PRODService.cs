using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREPORT_PRODService : IService<REPORT_PRODDto, CreateREPORT_PRODDto, UpdateREPORT_PRODDto, int>
{
    Task<IEnumerable<REPORT_PRODDto>> FindAsync(Expression<Func<REPORT_PROD, bool>> predicate);
}
