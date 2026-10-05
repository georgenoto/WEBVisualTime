using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE163Service : IService<TABLE163Dto, CreateTABLE163Dto, UpdateTABLE163Dto, int>
{
    Task<IEnumerable<TABLE163Dto>> FindAsync(Expression<Func<TABLE163, bool>> predicate);
}
