using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_NUM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBILLS_NUMService : IService<BILLS_NUMDto, CreateBILLS_NUMDto, UpdateBILLS_NUMDto, string>
{
    Task<IEnumerable<BILLS_NUMDto>> FindAsync(Expression<Func<BILLS_NUM, bool>> predicate);
}
