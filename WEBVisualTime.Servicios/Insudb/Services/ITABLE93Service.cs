using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE93;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE93Service : IService<TABLE93Dto, CreateTABLE93Dto, UpdateTABLE93Dto, int>
{
    Task<IEnumerable<TABLE93Dto>> FindAsync(Expression<Func<TABLE93, bool>> predicate);
}
