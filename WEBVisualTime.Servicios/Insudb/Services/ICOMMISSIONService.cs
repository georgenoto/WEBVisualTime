using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISSION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMISSIONService : IService<COMMISSIONDto, CreateCOMMISSIONDto, UpdateCOMMISSIONDto, string>
{
    Task<IEnumerable<COMMISSIONDto>> FindAsync(Expression<Func<COMMISSION, bool>> predicate);
}
