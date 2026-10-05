using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7044;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7044Service : IService<TABLE7044Dto, CreateTABLE7044Dto, UpdateTABLE7044Dto, int>
{
    Task<IEnumerable<TABLE7044Dto>> FindAsync(Expression<Func<TABLE7044, bool>> predicate);
}
