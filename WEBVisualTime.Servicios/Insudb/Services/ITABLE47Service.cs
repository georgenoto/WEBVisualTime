using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE47Service : IService<TABLE47Dto, CreateTABLE47Dto, UpdateTABLE47Dto, string>
{
    Task<IEnumerable<TABLE47Dto>> FindAsync(Expression<Func<TABLE47, bool>> predicate);
}
