using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBILLSService : IService<BILLSDto, CreateBILLSDto, UpdateBILLSDto, string>
{
    Task<IEnumerable<BILLSDto>> FindAsync(Expression<Func<BILLS, bool>> predicate);
}
