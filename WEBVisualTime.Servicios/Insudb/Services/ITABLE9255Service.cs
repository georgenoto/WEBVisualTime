using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9255;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9255Service : IService<TABLE9255Dto, CreateTABLE9255Dto, UpdateTABLE9255Dto, int>
{
    Task<IEnumerable<TABLE9255Dto>> FindAsync(Expression<Func<TABLE9255, bool>> predicate);
}
