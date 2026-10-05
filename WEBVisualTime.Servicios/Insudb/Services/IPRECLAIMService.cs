using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPRECLAIMService : IService<PRECLAIMDto, CreatePRECLAIMDto, UpdatePRECLAIMDto, long>
{
    Task<IEnumerable<PRECLAIMDto>> FindAsync(Expression<Func<PRECLAIM, bool>> predicate);
}
