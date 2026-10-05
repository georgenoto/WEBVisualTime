using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9243;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9243Service : IService<TABLE9243Dto, CreateTABLE9243Dto, UpdateTABLE9243Dto, int>
{
    Task<IEnumerable<TABLE9243Dto>> FindAsync(Expression<Func<TABLE9243, bool>> predicate);
}
