using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE693;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE693Service : IService<TABLE693Dto, CreateTABLE693Dto, UpdateTABLE693Dto, int>
{
    Task<IEnumerable<TABLE693Dto>> FindAsync(Expression<Func<TABLE693, bool>> predicate);
}
