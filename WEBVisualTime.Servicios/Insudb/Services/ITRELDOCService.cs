using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRELDOC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITRELDOCService : IService<TRELDOCDto, CreateTRELDOCDto, UpdateTRELDOCDto, long>
{
    Task<IEnumerable<TRELDOCDto>> FindAsync(Expression<Func<TRELDOC, bool>> predicate);
}
