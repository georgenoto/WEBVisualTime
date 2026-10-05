using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELCONCEPTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRELCONCEPTSService : IService<RELCONCEPTSDto, CreateRELCONCEPTSDto, UpdateRELCONCEPTSDto, long>
{
    Task<IEnumerable<RELCONCEPTSDto>> FindAsync(Expression<Func<RELCONCEPTS, bool>> predicate);
}
