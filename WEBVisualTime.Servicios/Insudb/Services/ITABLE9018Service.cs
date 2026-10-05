using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9018;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9018Service : IService<TABLE9018Dto, CreateTABLE9018Dto, UpdateTABLE9018Dto, int>
{
    Task<IEnumerable<TABLE9018Dto>> FindAsync(Expression<Func<TABLE9018, bool>> predicate);
}
