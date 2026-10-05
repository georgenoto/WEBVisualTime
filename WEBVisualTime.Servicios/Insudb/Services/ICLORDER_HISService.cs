using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_HIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLORDER_HISService : IService<CLORDER_HISDto, CreateCLORDER_HISDto, UpdateCLORDER_HISDto, long>
{
    Task<IEnumerable<CLORDER_HISDto>> FindAsync(Expression<Func<CLORDER_HIS, bool>> predicate);
}
