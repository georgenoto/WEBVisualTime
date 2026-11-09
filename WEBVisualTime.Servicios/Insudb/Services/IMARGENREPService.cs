using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MARGENREP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMARGENREPService : IService<MARGENREPDto, CreateMARGENREPDto, UpdateMARGENREPDto, string>
{
    Task<IEnumerable<MARGENREPDto>> FindAsync(Expression<Func<MARGENREP, bool>> predicate);
}
