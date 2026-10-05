using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9265Service : IService<TABLE9265Dto, CreateTABLE9265Dto, UpdateTABLE9265Dto, int>
{
    Task<IEnumerable<TABLE9265Dto>> FindAsync(Expression<Func<TABLE9265, bool>> predicate);
}
