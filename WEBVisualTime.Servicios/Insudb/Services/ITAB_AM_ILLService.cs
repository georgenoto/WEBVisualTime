using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_AM_ILLService : IService<TAB_AM_ILLDto, CreateTAB_AM_ILLDto, UpdateTAB_AM_ILLDto, string>
{
    Task<IEnumerable<TAB_AM_ILLDto>> FindAsync(Expression<Func<TAB_AM_ILL, bool>> predicate);
}
