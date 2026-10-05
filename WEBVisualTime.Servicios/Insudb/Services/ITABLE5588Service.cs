using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5588Service : IService<TABLE5588Dto, CreateTABLE5588Dto, UpdateTABLE5588Dto, int>
{
    Task<IEnumerable<TABLE5588Dto>> FindAsync(Expression<Func<TABLE5588, bool>> predicate);
}
