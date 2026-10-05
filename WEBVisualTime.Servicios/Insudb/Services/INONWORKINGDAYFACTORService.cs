using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NONWORKINGDAYFACTOR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INONWORKINGDAYFACTORService : IService<NONWORKINGDAYFACTORDto, CreateNONWORKINGDAYFACTORDto, UpdateNONWORKINGDAYFACTORDto, long>
{
    Task<IEnumerable<NONWORKINGDAYFACTORDto>> FindAsync(Expression<Func<NONWORKINGDAYFACTOR, bool>> predicate);
}
