using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9232;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9232Service : IService<TABLE9232Dto, CreateTABLE9232Dto, UpdateTABLE9232Dto, int>
{
    Task<IEnumerable<TABLE9232Dto>> FindAsync(Expression<Func<TABLE9232, bool>> predicate);
}
