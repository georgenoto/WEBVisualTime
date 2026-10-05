using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5677Service : IService<TABLE5677Dto, CreateTABLE5677Dto, UpdateTABLE5677Dto, int>
{
    Task<IEnumerable<TABLE5677Dto>> FindAsync(Expression<Func<TABLE5677, bool>> predicate);
}
