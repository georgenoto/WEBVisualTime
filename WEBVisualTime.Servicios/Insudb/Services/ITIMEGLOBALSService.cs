using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITIMEGLOBALSService : IService<TIMEGLOBALSDto, CreateTIMEGLOBALSDto, UpdateTIMEGLOBALSDto, string>
{
    Task<IEnumerable<TIMEGLOBALSDto>> FindAsync(Expression<Func<TIMEGLOBALS, bool>> predicate);
}
