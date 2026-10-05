using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_SPECI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILIFE_SPECIService : IService<LIFE_SPECIDto, CreateLIFE_SPECIDto, UpdateLIFE_SPECIDto, long>
{
    Task<IEnumerable<LIFE_SPECIDto>> FindAsync(Expression<Func<LIFE_SPECI, bool>> predicate);
}
