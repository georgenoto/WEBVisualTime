using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6805;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6805Service : IService<TABLE6805Dto, CreateTABLE6805Dto, UpdateTABLE6805Dto, int>
{
    Task<IEnumerable<TABLE6805Dto>> FindAsync(Expression<Func<TABLE6805, bool>> predicate);
}
