using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WAY_PAY_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IWAY_PAY_PRODService : IService<WAY_PAY_PRODDto, CreateWAY_PAY_PRODDto, UpdateWAY_PAY_PRODDto, string>
{
    Task<IEnumerable<WAY_PAY_PRODDto>> FindAsync(Expression<Func<WAY_PAY_PROD, bool>> predicate);
}
