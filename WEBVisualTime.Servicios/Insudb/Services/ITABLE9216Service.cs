using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9216;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9216Service : IService<TABLE9216Dto, CreateTABLE9216Dto, UpdateTABLE9216Dto, int>
{
    Task<IEnumerable<TABLE9216Dto>> FindAsync(Expression<Func<TABLE9216, bool>> predicate);
}
