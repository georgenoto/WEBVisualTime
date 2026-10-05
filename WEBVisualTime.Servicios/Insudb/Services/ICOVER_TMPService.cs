using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_TMP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVER_TMPService : IService<COVER_TMPDto, CreateCOVER_TMPDto, UpdateCOVER_TMPDto, string>
{
    Task<IEnumerable<COVER_TMPDto>> FindAsync(Expression<Func<COVER_TMP, bool>> predicate);
}
