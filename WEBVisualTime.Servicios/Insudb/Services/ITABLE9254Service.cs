using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9254Service : IService<TABLE9254Dto, CreateTABLE9254Dto, UpdateTABLE9254Dto, int>
{
    Task<IEnumerable<TABLE9254Dto>> FindAsync(Expression<Func<TABLE9254, bool>> predicate);
}
