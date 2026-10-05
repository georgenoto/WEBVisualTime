using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8101;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8101Service : IService<TABLE8101Dto, CreateTABLE8101Dto, UpdateTABLE8101Dto, int>
{
    Task<IEnumerable<TABLE8101Dto>> FindAsync(Expression<Func<TABLE8101, bool>> predicate);
}
