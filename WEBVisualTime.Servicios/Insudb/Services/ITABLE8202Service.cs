using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8202;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8202Service : IService<TABLE8202Dto, CreateTABLE8202Dto, UpdateTABLE8202Dto, long>
{
    Task<IEnumerable<TABLE8202Dto>> FindAsync(Expression<Func<TABLE8202, bool>> predicate);
}
