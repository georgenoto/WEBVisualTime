using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8600Service : IService<TABLE8600Dto, CreateTABLE8600Dto, UpdateTABLE8600Dto, string>
{
    Task<IEnumerable<TABLE8600Dto>> FindAsync(Expression<Func<TABLE8600, bool>> predicate);
}
