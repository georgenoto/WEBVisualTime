using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8008;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8008Service : IService<TABLE8008Dto, CreateTABLE8008Dto, UpdateTABLE8008Dto, int>
{
    Task<IEnumerable<TABLE8008Dto>> FindAsync(Expression<Func<TABLE8008, bool>> predicate);
}
