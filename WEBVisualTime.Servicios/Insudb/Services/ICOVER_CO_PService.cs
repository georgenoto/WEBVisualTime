using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_CO_P;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVER_CO_PService : IService<COVER_CO_PDto, CreateCOVER_CO_PDto, UpdateCOVER_CO_PDto, string>
{
    Task<IEnumerable<COVER_CO_PDto>> FindAsync(Expression<Func<COVER_CO_P, bool>> predicate);
}
