using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCPOL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIDOCPOLService : IService<CLIDOCPOLDto, CreateCLIDOCPOLDto, UpdateCLIDOCPOLDto, string>
{
    Task<IEnumerable<CLIDOCPOLDto>> FindAsync(Expression<Func<CLIDOCPOL, bool>> predicate);
}
