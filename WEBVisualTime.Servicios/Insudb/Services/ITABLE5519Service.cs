using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5519;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5519Service : IService<TABLE5519Dto, CreateTABLE5519Dto, UpdateTABLE5519Dto, int>
{
    Task<IEnumerable<TABLE5519Dto>> FindAsync(Expression<Func<TABLE5519, bool>> predicate);
}
