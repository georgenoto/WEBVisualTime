using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DEPEND_SHEET;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDEPEND_SHEETService : IService<DEPEND_SHEETDto, CreateDEPEND_SHEETDto, UpdateDEPEND_SHEETDto, string>
{
    Task<IEnumerable<DEPEND_SHEETDto>> FindAsync(Expression<Func<DEPEND_SHEET, bool>> predicate);
}
