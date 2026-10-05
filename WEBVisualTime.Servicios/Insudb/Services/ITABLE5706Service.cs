using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5706;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5706Service : IService<TABLE5706Dto, CreateTABLE5706Dto, UpdateTABLE5706Dto, int>
{
    Task<IEnumerable<TABLE5706Dto>> FindAsync(Expression<Func<TABLE5706, bool>> predicate);
}
