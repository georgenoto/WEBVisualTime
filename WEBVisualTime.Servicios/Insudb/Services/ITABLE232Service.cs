using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE232;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE232Service : IService<TABLE232Dto, CreateTABLE232Dto, UpdateTABLE232Dto, int>
{
    Task<IEnumerable<TABLE232Dto>> FindAsync(Expression<Func<TABLE232, bool>> predicate);
}
