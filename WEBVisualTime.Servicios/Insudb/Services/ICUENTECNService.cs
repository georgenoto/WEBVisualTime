using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CUENTECN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICUENTECNService : IService<CUENTECNDto, CreateCUENTECNDto, UpdateCUENTECNDto, long>
{
    Task<IEnumerable<CUENTECNDto>> FindAsync(Expression<Func<CUENTECN, bool>> predicate);
}
