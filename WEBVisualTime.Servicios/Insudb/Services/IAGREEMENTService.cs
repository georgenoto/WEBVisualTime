using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IAGREEMENTService : IService<AGREEMENTDto, CreateAGREEMENTDto, UpdateAGREEMENTDto, int>
{
    Task<IEnumerable<AGREEMENTDto>> FindAsync(Expression<Func<AGREEMENT, bool>> predicate);
}
