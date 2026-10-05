using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_FRE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREINSU_FREService : IService<REINSU_FREDto, CreateREINSU_FREDto, UpdateREINSU_FREDto, DateTime>
{
    Task<IEnumerable<REINSU_FREDto>> FindAsync(Expression<Func<REINSU_FRE, bool>> predicate);
}
