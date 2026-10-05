using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5579;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5579Service : IService<TABLE5579Dto, CreateTABLE5579Dto, UpdateTABLE5579Dto, int>
{
    Task<IEnumerable<TABLE5579Dto>> FindAsync(Expression<Func<TABLE5579, bool>> predicate);
}
