using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9020;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9020Service : IService<TABLE9020Dto, CreateTABLE9020Dto, UpdateTABLE9020Dto, int>
{
    Task<IEnumerable<TABLE9020Dto>> FindAsync(Expression<Func<TABLE9020, bool>> predicate);
}
