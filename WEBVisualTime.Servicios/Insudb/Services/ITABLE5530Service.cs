using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5530;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5530Service : IService<TABLE5530Dto, CreateTABLE5530Dto, UpdateTABLE5530Dto, int>
{
    Task<IEnumerable<TABLE5530Dto>> FindAsync(Expression<Func<TABLE5530, bool>> predicate);
}
