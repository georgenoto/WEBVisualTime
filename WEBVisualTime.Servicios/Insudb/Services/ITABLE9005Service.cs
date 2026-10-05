using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9005Service : IService<TABLE9005Dto, CreateTABLE9005Dto, UpdateTABLE9005Dto, int>
{
    Task<IEnumerable<TABLE9005Dto>> FindAsync(Expression<Func<TABLE9005, bool>> predicate);
}
