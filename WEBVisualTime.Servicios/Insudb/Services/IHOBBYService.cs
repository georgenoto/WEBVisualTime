using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOBBY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHOBBYService : IService<HOBBYDto, CreateHOBBYDto, UpdateHOBBYDto, int>
{
    Task<IEnumerable<HOBBYDto>> FindAsync(Expression<Func<HOBBY, bool>> predicate);
}
