using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5701;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5701Service : IService<TABLE5701Dto, CreateTABLE5701Dto, UpdateTABLE5701Dto, int>
{
    Task<IEnumerable<TABLE5701Dto>> FindAsync(Expression<Func<TABLE5701, bool>> predicate);
}
