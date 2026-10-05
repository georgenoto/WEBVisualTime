using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE48;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE48Service : IService<TABLE48Dto, CreateTABLE48Dto, UpdateTABLE48Dto, int>
{
    Task<IEnumerable<TABLE48Dto>> FindAsync(Expression<Func<TABLE48, bool>> predicate);
}
