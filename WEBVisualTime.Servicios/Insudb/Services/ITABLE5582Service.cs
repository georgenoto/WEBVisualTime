using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5582;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5582Service : IService<TABLE5582Dto, CreateTABLE5582Dto, UpdateTABLE5582Dto, int>
{
    Task<IEnumerable<TABLE5582Dto>> FindAsync(Expression<Func<TABLE5582, bool>> predicate);
}
