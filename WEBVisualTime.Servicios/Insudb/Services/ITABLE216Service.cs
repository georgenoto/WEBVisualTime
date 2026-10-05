using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE216;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE216Service : IService<TABLE216Dto, CreateTABLE216Dto, UpdateTABLE216Dto, long>
{
    Task<IEnumerable<TABLE216Dto>> FindAsync(Expression<Func<TABLE216, bool>> predicate);
}
