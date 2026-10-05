using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE89;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE89Service : IService<TABLE89Dto, CreateTABLE89Dto, UpdateTABLE89Dto, long>
{
    Task<IEnumerable<TABLE89Dto>> FindAsync(Expression<Func<TABLE89, bool>> predicate);
}
