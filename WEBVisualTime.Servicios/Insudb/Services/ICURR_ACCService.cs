using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICURR_ACCService : IService<CURR_ACCDto, CreateCURR_ACCDto, UpdateCURR_ACCDto, int>
{
    Task<IEnumerable<CURR_ACCDto>> FindAsync(Expression<Func<CURR_ACC, bool>> predicate);
}
