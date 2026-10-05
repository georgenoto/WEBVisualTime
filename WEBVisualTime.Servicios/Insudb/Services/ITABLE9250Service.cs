using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9250Service : IService<TABLE9250Dto, CreateTABLE9250Dto, UpdateTABLE9250Dto, int>
{
    Task<IEnumerable<TABLE9250Dto>> FindAsync(Expression<Func<TABLE9250, bool>> predicate);
}
