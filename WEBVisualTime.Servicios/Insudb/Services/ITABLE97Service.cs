using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE97Service : IService<TABLE97Dto, CreateTABLE97Dto, UpdateTABLE97Dto, int>
{
    Task<IEnumerable<TABLE97Dto>> FindAsync(Expression<Func<TABLE97, bool>> predicate);
}
