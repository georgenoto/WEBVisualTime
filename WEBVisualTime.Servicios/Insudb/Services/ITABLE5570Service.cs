using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5570Service : IService<TABLE5570Dto, CreateTABLE5570Dto, UpdateTABLE5570Dto, int>
{
    Task<IEnumerable<TABLE5570Dto>> FindAsync(Expression<Func<TABLE5570, bool>> predicate);
}
