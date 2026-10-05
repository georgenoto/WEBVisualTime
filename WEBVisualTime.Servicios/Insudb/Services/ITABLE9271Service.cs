using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9271Service : IService<TABLE9271Dto, CreateTABLE9271Dto, UpdateTABLE9271Dto, int>
{
    Task<IEnumerable<TABLE9271Dto>> FindAsync(Expression<Func<TABLE9271, bool>> predicate);
}
