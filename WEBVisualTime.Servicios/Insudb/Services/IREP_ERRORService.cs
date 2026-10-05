using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_ERROR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREP_ERRORService : IService<REP_ERRORDto, CreateREP_ERRORDto, UpdateREP_ERRORDto, string>
{
    Task<IEnumerable<REP_ERRORDto>> FindAsync(Expression<Func<REP_ERROR, bool>> predicate);
}
