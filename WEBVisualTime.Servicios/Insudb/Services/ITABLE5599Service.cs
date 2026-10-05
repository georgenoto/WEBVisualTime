using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5599;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5599Service : IService<TABLE5599Dto, CreateTABLE5599Dto, UpdateTABLE5599Dto, int>
{
    Task<IEnumerable<TABLE5599Dto>> FindAsync(Expression<Func<TABLE5599, bool>> predicate);
}
