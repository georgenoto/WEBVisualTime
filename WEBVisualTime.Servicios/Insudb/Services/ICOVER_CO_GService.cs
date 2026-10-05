using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_CO_G;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVER_CO_GService : IService<COVER_CO_GDto, CreateCOVER_CO_GDto, UpdateCOVER_CO_GDto, string>
{
    Task<IEnumerable<COVER_CO_GDto>> FindAsync(Expression<Func<COVER_CO_G, bool>> predicate);
}
