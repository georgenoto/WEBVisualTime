using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISITUATIONService : IService<SITUATIONDto, CreateSITUATIONDto, UpdateSITUATIONDto, string>
{
    Task<IEnumerable<SITUATIONDto>> FindAsync(Expression<Func<SITUATION, bool>> predicate);
}
