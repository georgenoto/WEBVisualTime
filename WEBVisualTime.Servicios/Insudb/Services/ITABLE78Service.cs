using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE78Service : IService<TABLE78Dto, CreateTABLE78Dto, UpdateTABLE78Dto, int>
{
    Task<IEnumerable<TABLE78Dto>> FindAsync(Expression<Func<TABLE78, bool>> predicate);
}
