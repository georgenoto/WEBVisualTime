using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_CLEAR_VTIME;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREP_CLEAR_VTIMEService : IService<REP_CLEAR_VTIMEDto, CreateREP_CLEAR_VTIMEDto, UpdateREP_CLEAR_VTIMEDto, string>
{
    Task<IEnumerable<REP_CLEAR_VTIMEDto>> FindAsync(Expression<Func<REP_CLEAR_VTIME, bool>> predicate);
}
