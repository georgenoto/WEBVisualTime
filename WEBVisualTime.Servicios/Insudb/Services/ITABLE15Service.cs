using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE15Service : IService<TABLE15Dto, CreateTABLE15Dto, UpdateTABLE15Dto, int>
{
    Task<IEnumerable<TABLE15Dto>> FindAsync(Expression<Func<TABLE15, bool>> predicate);
}
