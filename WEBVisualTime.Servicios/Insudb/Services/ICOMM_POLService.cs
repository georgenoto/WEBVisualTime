using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_POL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMM_POLService : IService<COMM_POLDto, CreateCOMM_POLDto, UpdateCOMM_POLDto, string>
{
    Task<IEnumerable<COMM_POLDto>> FindAsync(Expression<Func<COMM_POL, bool>> predicate);
}
