using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE165;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE165Service : IService<TABLE165Dto, CreateTABLE165Dto, UpdateTABLE165Dto, int>
{
    Task<IEnumerable<TABLE165Dto>> FindAsync(Expression<Func<TABLE165, bool>> predicate);
}
