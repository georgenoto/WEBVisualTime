using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5001Service : IService<TABLE5001Dto, CreateTABLE5001Dto, UpdateTABLE5001Dto, int>
{
    Task<IEnumerable<TABLE5001Dto>> FindAsync(Expression<Func<TABLE5001, bool>> predicate);
}
