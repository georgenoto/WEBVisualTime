using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5612;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5612Service : IService<TABLE5612Dto, CreateTABLE5612Dto, UpdateTABLE5612Dto, int>
{
    Task<IEnumerable<TABLE5612Dto>> FindAsync(Expression<Func<TABLE5612, bool>> predicate);
}
