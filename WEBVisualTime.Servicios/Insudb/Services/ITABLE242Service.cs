using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE242;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE242Service : IService<TABLE242Dto, CreateTABLE242Dto, UpdateTABLE242Dto, int>
{
    Task<IEnumerable<TABLE242Dto>> FindAsync(Expression<Func<TABLE242, bool>> predicate);
}
