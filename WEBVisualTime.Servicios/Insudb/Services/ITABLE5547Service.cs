using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5547;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5547Service : IService<TABLE5547Dto, CreateTABLE5547Dto, UpdateTABLE5547Dto, int>
{
    Task<IEnumerable<TABLE5547Dto>> FindAsync(Expression<Func<TABLE5547, bool>> predicate);
}
