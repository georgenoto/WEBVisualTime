using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REQUEST;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREQUESTService : IService<REQUESTDto, CreateREQUESTDto, UpdateREQUESTDto, string>
{
    Task<IEnumerable<REQUESTDto>> FindAsync(Expression<Func<REQUEST, bool>> predicate);
}
