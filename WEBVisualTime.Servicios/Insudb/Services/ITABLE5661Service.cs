using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5661;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5661Service : IService<TABLE5661Dto, CreateTABLE5661Dto, UpdateTABLE5661Dto, int>
{
    Task<IEnumerable<TABLE5661Dto>> FindAsync(Expression<Func<TABLE5661, bool>> predicate);
}
