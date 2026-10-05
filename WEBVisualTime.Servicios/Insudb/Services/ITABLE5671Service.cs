using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5671;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5671Service : IService<TABLE5671Dto, CreateTABLE5671Dto, UpdateTABLE5671Dto, int>
{
    Task<IEnumerable<TABLE5671Dto>> FindAsync(Expression<Func<TABLE5671, bool>> predicate);
}
