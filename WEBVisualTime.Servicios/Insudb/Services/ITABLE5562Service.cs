using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5562;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5562Service : IService<TABLE5562Dto, CreateTABLE5562Dto, UpdateTABLE5562Dto, int>
{
    Task<IEnumerable<TABLE5562Dto>> FindAsync(Expression<Func<TABLE5562, bool>> predicate);
}
