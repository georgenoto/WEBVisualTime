using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE525;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE525Service : IService<TABLE525Dto, CreateTABLE525Dto, UpdateTABLE525Dto, int>
{
    Task<IEnumerable<TABLE525Dto>> FindAsync(Expression<Func<TABLE525, bool>> predicate);
}
