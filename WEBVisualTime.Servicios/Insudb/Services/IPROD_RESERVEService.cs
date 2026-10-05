using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_RESERVE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROD_RESERVEService : IService<PROD_RESERVEDto, CreatePROD_RESERVEDto, UpdatePROD_RESERVEDto, int>
{
    Task<IEnumerable<PROD_RESERVEDto>> FindAsync(Expression<Func<PROD_RESERVE, bool>> predicate);
}
