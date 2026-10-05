using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9100;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9100Service : IService<TABLE9100Dto, CreateTABLE9100Dto, UpdateTABLE9100Dto, int>
{
    Task<IEnumerable<TABLE9100Dto>> FindAsync(Expression<Func<TABLE9100, bool>> predicate);
}
