using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE248;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE248Service : IService<TABLE248Dto, CreateTABLE248Dto, UpdateTABLE248Dto, int>
{
    Task<IEnumerable<TABLE248Dto>> FindAsync(Expression<Func<TABLE248, bool>> predicate);
}
