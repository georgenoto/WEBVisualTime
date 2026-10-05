using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9251Service : IService<TABLE9251Dto, CreateTABLE9251Dto, UpdateTABLE9251Dto, int>
{
    Task<IEnumerable<TABLE9251Dto>> FindAsync(Expression<Func<TABLE9251, bool>> predicate);
}
