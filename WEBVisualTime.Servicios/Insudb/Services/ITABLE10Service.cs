using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE10Service : IService<TABLE10Dto, CreateTABLE10Dto, UpdateTABLE10Dto, int>
{
    Task<IEnumerable<TABLE10Dto>> FindAsync(Expression<Func<TABLE10, bool>> predicate);
}
