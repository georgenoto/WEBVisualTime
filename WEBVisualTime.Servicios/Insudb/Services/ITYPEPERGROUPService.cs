using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPEPERGROUP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITYPEPERGROUPService : IService<TYPEPERGROUPDto, CreateTYPEPERGROUPDto, UpdateTYPEPERGROUPDto, string>
{
    Task<IEnumerable<TYPEPERGROUPDto>> FindAsync(Expression<Func<TYPEPERGROUP, bool>> predicate);
}
