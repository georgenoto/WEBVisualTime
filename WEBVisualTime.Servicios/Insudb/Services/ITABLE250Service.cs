using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE250;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE250Service : IService<TABLE250Dto, CreateTABLE250Dto, UpdateTABLE250Dto, int>
{
    Task<IEnumerable<TABLE250Dto>> FindAsync(Expression<Func<TABLE250, bool>> predicate);
}
