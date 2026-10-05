using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTSHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IREPORTSHEETService : IService<REPORTSHEETDto, CreateREPORTSHEETDto, UpdateREPORTSHEETDto, string>
{
    Task<IEnumerable<REPORTSHEETDto>> FindAsync(Expression<Func<REPORTSHEET, bool>> predicate);
}
