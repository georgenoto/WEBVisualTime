using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5742;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5742Service : IService<TABLE5742Dto, CreateTABLE5742Dto, UpdateTABLE5742Dto, int>
{
    Task<IEnumerable<TABLE5742Dto>> FindAsync(Expression<Func<TABLE5742, bool>> predicate);
}
