using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6012;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE6012Service : IService<TABLE6012Dto, CreateTABLE6012Dto, UpdateTABLE6012Dto, int>
{
    Task<IEnumerable<TABLE6012Dto>> FindAsync(Expression<Func<TABLE6012, bool>> predicate);
}
