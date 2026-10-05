using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8106;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8106Service : IService<TABLE8106Dto, CreateTABLE8106Dto, UpdateTABLE8106Dto, long>
{
    Task<IEnumerable<TABLE8106Dto>> FindAsync(Expression<Func<TABLE8106, bool>> predicate);
}
