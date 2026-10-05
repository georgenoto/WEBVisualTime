using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5745;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5745Service : IService<TABLE5745Dto, CreateTABLE5745Dto, UpdateTABLE5745Dto, string>
{
    Task<IEnumerable<TABLE5745Dto>> FindAsync(Expression<Func<TABLE5745, bool>> predicate);
}
