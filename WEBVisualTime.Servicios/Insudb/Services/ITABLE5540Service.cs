using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5540;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5540Service : IService<TABLE5540Dto, CreateTABLE5540Dto, UpdateTABLE5540Dto, int>
{
    Task<IEnumerable<TABLE5540Dto>> FindAsync(Expression<Func<TABLE5540, bool>> predicate);
}
