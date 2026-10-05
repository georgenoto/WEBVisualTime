using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE84;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE84Service : IService<TABLE84Dto, CreateTABLE84Dto, UpdateTABLE84Dto, int>
{
    Task<IEnumerable<TABLE84Dto>> FindAsync(Expression<Func<TABLE84, bool>> predicate);
}
