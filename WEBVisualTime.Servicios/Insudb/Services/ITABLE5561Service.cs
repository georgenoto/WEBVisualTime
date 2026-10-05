using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5561;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5561Service : IService<TABLE5561Dto, CreateTABLE5561Dto, UpdateTABLE5561Dto, int>
{
    Task<IEnumerable<TABLE5561Dto>> FindAsync(Expression<Func<TABLE5561, bool>> predicate);
}
