using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTMASTER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREPORTMASTERService : IService<REPORTMASTERDto, CreateREPORTMASTERDto, UpdateREPORTMASTERDto, int>
{
    Task<IEnumerable<REPORTMASTERDto>> FindAsync(Expression<Func<REPORTMASTER, bool>> predicate);
}
