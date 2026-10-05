using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5633;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5633Service : IService<TABLE5633Dto, CreateTABLE5633Dto, UpdateTABLE5633Dto, int>
{
    Task<IEnumerable<TABLE5633Dto>> FindAsync(Expression<Func<TABLE5633, bool>> predicate);
}
