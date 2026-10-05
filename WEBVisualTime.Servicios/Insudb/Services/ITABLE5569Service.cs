using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5569;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5569Service : IService<TABLE5569Dto, CreateTABLE5569Dto, UpdateTABLE5569Dto, int>
{
    Task<IEnumerable<TABLE5569Dto>> FindAsync(Expression<Func<TABLE5569, bool>> predicate);
}
