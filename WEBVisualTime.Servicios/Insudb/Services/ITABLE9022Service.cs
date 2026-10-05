using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9022;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9022Service : IService<TABLE9022Dto, CreateTABLE9022Dto, UpdateTABLE9022Dto, int>
{
    Task<IEnumerable<TABLE9022Dto>> FindAsync(Expression<Func<TABLE9022, bool>> predicate);
}
