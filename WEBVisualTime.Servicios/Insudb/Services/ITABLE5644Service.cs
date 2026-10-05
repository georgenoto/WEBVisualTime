using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5644;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5644Service : IService<TABLE5644Dto, CreateTABLE5644Dto, UpdateTABLE5644Dto, int>
{
    Task<IEnumerable<TABLE5644Dto>> FindAsync(Expression<Func<TABLE5644, bool>> predicate);
}
