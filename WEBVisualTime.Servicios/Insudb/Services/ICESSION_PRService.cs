using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_PR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICESSION_PRService : IService<CESSION_PRDto, CreateCESSION_PRDto, UpdateCESSION_PRDto, string>
{
    Task<IEnumerable<CESSION_PRDto>> FindAsync(Expression<Func<CESSION_PR, bool>> predicate);
}
