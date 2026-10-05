using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE533;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE533Service : IService<TABLE533Dto, CreateTABLE533Dto, UpdateTABLE533Dto, int>
{
    Task<IEnumerable<TABLE533Dto>> FindAsync(Expression<Func<TABLE533, bool>> predicate);
}
