using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5631;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5631Service : IService<TABLE5631Dto, CreateTABLE5631Dto, UpdateTABLE5631Dto, int>
{
    Task<IEnumerable<TABLE5631Dto>> FindAsync(Expression<Func<TABLE5631, bool>> predicate);
}
