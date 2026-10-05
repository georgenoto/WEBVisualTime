using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE132Service : IService<TABLE132Dto, CreateTABLE132Dto, UpdateTABLE132Dto, string>
{
    Task<IEnumerable<TABLE132Dto>> FindAsync(Expression<Func<TABLE132, bool>> predicate);
}
