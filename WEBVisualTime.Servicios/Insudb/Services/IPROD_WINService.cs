using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_WIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROD_WINService : IService<PROD_WINDto, CreatePROD_WINDto, UpdatePROD_WINDto, int>
{
    Task<IEnumerable<PROD_WINDto>> FindAsync(Expression<Func<PROD_WIN, bool>> predicate);
}
