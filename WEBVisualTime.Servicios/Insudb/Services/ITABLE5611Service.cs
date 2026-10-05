using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5611;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5611Service : IService<TABLE5611Dto, CreateTABLE5611Dto, UpdateTABLE5611Dto, int>
{
    Task<IEnumerable<TABLE5611Dto>> FindAsync(Expression<Func<TABLE5611, bool>> predicate);
}
