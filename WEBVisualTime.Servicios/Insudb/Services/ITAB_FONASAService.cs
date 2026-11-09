using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FONASA;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_FONASAService : IService<TAB_FONASADto, CreateTAB_FONASADto, UpdateTAB_FONASADto, string>
{
    Task<IEnumerable<TAB_FONASADto>> FindAsync(Expression<Func<TAB_FONASA, bool>> predicate);
}
