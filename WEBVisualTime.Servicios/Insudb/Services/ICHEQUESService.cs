using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICHEQUESService : IService<CHEQUESDto, CreateCHEQUESDto, UpdateCHEQUESDto, long>
{
    Task<IEnumerable<CHEQUESDto>> FindAsync(Expression<Func<CHEQUES, bool>> predicate);
}
