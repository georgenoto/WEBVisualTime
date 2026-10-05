using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE98;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE98Service : IService<TABLE98Dto, CreateTABLE98Dto, UpdateTABLE98Dto, int>
{
    Task<IEnumerable<TABLE98Dto>> FindAsync(Expression<Func<TABLE98, bool>> predicate);
}
