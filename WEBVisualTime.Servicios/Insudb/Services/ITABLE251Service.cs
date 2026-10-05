using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE251;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE251Service : IService<TABLE251Dto, CreateTABLE251Dto, UpdateTABLE251Dto, long>
{
    Task<IEnumerable<TABLE251Dto>> FindAsync(Expression<Func<TABLE251, bool>> predicate);
}
