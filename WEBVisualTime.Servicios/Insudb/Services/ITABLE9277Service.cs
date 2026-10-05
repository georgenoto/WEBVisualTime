using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9277;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9277Service : IService<TABLE9277Dto, CreateTABLE9277Dto, UpdateTABLE9277Dto, int>
{
    Task<IEnumerable<TABLE9277Dto>> FindAsync(Expression<Func<TABLE9277, bool>> predicate);
}
