using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5516;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5516Service : IService<TABLE5516Dto, CreateTABLE5516Dto, UpdateTABLE5516Dto, int>
{
    Task<IEnumerable<TABLE5516Dto>> FindAsync(Expression<Func<TABLE5516, bool>> predicate);
}
