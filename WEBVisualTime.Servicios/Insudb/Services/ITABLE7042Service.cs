using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7042;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7042Service : IService<TABLE7042Dto, CreateTABLE7042Dto, UpdateTABLE7042Dto, int>
{
    Task<IEnumerable<TABLE7042Dto>> FindAsync(Expression<Func<TABLE7042, bool>> predicate);
}
