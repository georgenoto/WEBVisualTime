using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5617;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5617Service : IService<TABLE5617Dto, CreateTABLE5617Dto, UpdateTABLE5617Dto, int>
{
    Task<IEnumerable<TABLE5617Dto>> FindAsync(Expression<Func<TABLE5617, bool>> predicate);
}
