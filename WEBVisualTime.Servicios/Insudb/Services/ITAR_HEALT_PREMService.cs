using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAR_HEALT_PREM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAR_HEALT_PREMService : IService<TAR_HEALT_PREMDto, CreateTAR_HEALT_PREMDto, UpdateTAR_HEALT_PREMDto, int>
{
    Task<IEnumerable<TAR_HEALT_PREMDto>> FindAsync(Expression<Func<TAR_HEALT_PREM, bool>> predicate);
}
