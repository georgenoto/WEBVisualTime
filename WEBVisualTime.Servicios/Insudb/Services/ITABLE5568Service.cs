using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5568;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5568Service : IService<TABLE5568Dto, CreateTABLE5568Dto, UpdateTABLE5568Dto, int>
{
    Task<IEnumerable<TABLE5568Dto>> FindAsync(Expression<Func<TABLE5568, bool>> predicate);
}
