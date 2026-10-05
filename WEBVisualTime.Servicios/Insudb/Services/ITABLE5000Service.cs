using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5000Service : IService<TABLE5000Dto, CreateTABLE5000Dto, UpdateTABLE5000Dto, int>
{
    Task<IEnumerable<TABLE5000Dto>> FindAsync(Expression<Func<TABLE5000, bool>> predicate);
}
