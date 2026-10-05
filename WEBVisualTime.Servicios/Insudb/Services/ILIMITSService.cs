using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIMITS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILIMITSService : IService<LIMITSDto, CreateLIMITSDto, UpdateLIMITSDto, string>
{
    Task<IEnumerable<LIMITSDto>> FindAsync(Expression<Func<LIMITS, bool>> predicate);
}
