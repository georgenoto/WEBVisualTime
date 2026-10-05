using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISS_PR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOMMISS_PRService : IService<COMMISS_PRDto, CreateCOMMISS_PRDto, UpdateCOMMISS_PRDto, long>
{
    Task<IEnumerable<COMMISS_PRDto>> FindAsync(Expression<Func<COMMISS_PR, bool>> predicate);
}
