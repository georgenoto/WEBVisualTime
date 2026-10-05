using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBILLS_HISService : IService<BILLS_HISDto, CreateBILLS_HISDto, UpdateBILLS_HISDto, string>
{
    Task<IEnumerable<BILLS_HISDto>> FindAsync(Expression<Func<BILLS_HIS, bool>> predicate);
}
