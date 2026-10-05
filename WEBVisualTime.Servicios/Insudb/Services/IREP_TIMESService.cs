using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_TIMES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREP_TIMESService : IService<REP_TIMESDto, CreateREP_TIMESDto, UpdateREP_TIMESDto, string>
{
    Task<IEnumerable<REP_TIMESDto>> FindAsync(Expression<Func<REP_TIMES, bool>> predicate);
}
