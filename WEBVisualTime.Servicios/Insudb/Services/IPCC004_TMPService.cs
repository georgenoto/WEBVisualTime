using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_TMP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPCC004_TMPService : IService<PCC004_TMPDto, CreatePCC004_TMPDto, UpdatePCC004_TMPDto, DateTime>
{
    Task<IEnumerable<PCC004_TMPDto>> FindAsync(Expression<Func<PCC004_TMP, bool>> predicate);
}
