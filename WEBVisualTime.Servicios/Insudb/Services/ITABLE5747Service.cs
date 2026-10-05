using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5747;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5747Service : IService<TABLE5747Dto, CreateTABLE5747Dto, UpdateTABLE5747Dto, int>
{
    Task<IEnumerable<TABLE5747Dto>> FindAsync(Expression<Func<TABLE5747, bool>> predicate);
}
