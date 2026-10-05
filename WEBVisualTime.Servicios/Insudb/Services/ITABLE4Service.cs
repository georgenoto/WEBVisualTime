using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE4;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE4Service : IService<TABLE4Dto, CreateTABLE4Dto, UpdateTABLE4Dto, int>
{
    Task<IEnumerable<TABLE4Dto>> FindAsync(Expression<Func<TABLE4, bool>> predicate);
}
