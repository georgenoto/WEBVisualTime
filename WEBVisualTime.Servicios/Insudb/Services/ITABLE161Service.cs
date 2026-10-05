using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE161;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE161Service : IService<TABLE161Dto, CreateTABLE161Dto, UpdateTABLE161Dto, string>
{
    Task<IEnumerable<TABLE161Dto>> FindAsync(Expression<Func<TABLE161, bool>> predicate);
}
