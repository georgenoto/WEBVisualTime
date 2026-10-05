using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE697;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE697Service : IService<TABLE697Dto, CreateTABLE697Dto, UpdateTABLE697Dto, int>
{
    Task<IEnumerable<TABLE697Dto>> FindAsync(Expression<Func<TABLE697, bool>> predicate);
}
