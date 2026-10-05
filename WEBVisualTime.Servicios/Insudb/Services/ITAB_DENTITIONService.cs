using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_DENTITIONService : IService<TAB_DENTITIONDto, CreateTAB_DENTITIONDto, UpdateTAB_DENTITIONDto, int>
{
    Task<IEnumerable<TAB_DENTITIONDto>> FindAsync(Expression<Func<TAB_DENTITION, bool>> predicate);
}
