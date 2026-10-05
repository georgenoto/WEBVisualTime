using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE640;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE640Service : IService<TABLE640Dto, CreateTABLE640Dto, UpdateTABLE640Dto, int>
{
    Task<IEnumerable<TABLE640Dto>> FindAsync(Expression<Func<TABLE640, bool>> predicate);
}
