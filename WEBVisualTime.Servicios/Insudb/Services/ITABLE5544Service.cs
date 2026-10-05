using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5544;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5544Service : IService<TABLE5544Dto, CreateTABLE5544Dto, UpdateTABLE5544Dto, int>
{
    Task<IEnumerable<TABLE5544Dto>> FindAsync(Expression<Func<TABLE5544, bool>> predicate);
}
