using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSREP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISIGNSREPService : IService<SIGNSREPDto, CreateSIGNSREPDto, UpdateSIGNSREPDto, string>
{
    Task<IEnumerable<SIGNSREPDto>> FindAsync(Expression<Func<SIGNSREP, bool>> predicate);
}
