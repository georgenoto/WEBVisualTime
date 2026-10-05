using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5800;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5800Service : IService<TABLE5800Dto, CreateTABLE5800Dto, UpdateTABLE5800Dto, int>
{
    Task<IEnumerable<TABLE5800Dto>> FindAsync(Expression<Func<TABLE5800, bool>> predicate);
}
