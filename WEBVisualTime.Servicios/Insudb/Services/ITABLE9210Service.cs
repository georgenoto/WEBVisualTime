using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9210;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9210Service : IService<TABLE9210Dto, CreateTABLE9210Dto, UpdateTABLE9210Dto, int>
{
    Task<IEnumerable<TABLE9210Dto>> FindAsync(Expression<Func<TABLE9210, bool>> predicate);
}
