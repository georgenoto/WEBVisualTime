using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE308;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE308Service : IService<TABLE308Dto, CreateTABLE308Dto, UpdateTABLE308Dto, long>
{
    Task<IEnumerable<TABLE308Dto>> FindAsync(Expression<Func<TABLE308, bool>> predicate);
}
