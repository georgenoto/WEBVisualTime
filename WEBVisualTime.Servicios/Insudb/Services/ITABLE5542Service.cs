using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5542;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5542Service : IService<TABLE5542Dto, CreateTABLE5542Dto, UpdateTABLE5542Dto, int>
{
    Task<IEnumerable<TABLE5542Dto>> FindAsync(Expression<Func<TABLE5542, bool>> predicate);
}
