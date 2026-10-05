using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE221;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE221Service : IService<TABLE221Dto, CreateTABLE221Dto, UpdateTABLE221Dto, long>
{
    Task<IEnumerable<TABLE221Dto>> FindAsync(Expression<Func<TABLE221, bool>> predicate);
}
