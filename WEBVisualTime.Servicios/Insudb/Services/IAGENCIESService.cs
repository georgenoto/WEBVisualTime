using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IAGENCIESService : IService<AGENCIESDto, CreateAGENCIESDto, UpdateAGENCIESDto, int>
{
    Task<IEnumerable<AGENCIESDto>> FindAsync(Expression<Func<AGENCIES, bool>> predicate);
}
