using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE137;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE137Service : IService<TABLE137Dto, CreateTABLE137Dto, UpdateTABLE137Dto, int>
{
    Task<IEnumerable<TABLE137Dto>> FindAsync(Expression<Func<TABLE137, bool>> predicate);
}
