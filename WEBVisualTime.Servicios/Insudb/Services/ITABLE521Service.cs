using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE521;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE521Service : IService<TABLE521Dto, CreateTABLE521Dto, UpdateTABLE521Dto, int>
{
    Task<IEnumerable<TABLE521Dto>> FindAsync(Expression<Func<TABLE521, bool>> predicate);
}
