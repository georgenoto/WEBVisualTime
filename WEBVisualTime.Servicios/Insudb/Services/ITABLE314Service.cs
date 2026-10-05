using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE314;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE314Service : IService<TABLE314Dto, CreateTABLE314Dto, UpdateTABLE314Dto, int>
{
    Task<IEnumerable<TABLE314Dto>> FindAsync(Expression<Func<TABLE314, bool>> predicate);
}
