using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_TOT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMM_TOTService : IService<COMM_TOTDto, CreateCOMM_TOTDto, UpdateCOMM_TOTDto, long>
{
    Task<IEnumerable<COMM_TOTDto>> FindAsync(Expression<Func<COMM_TOT, bool>> predicate);
}
