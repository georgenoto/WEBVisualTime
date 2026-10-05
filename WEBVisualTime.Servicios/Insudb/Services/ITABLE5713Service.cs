using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5713;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5713Service : IService<TABLE5713Dto, CreateTABLE5713Dto, UpdateTABLE5713Dto, int>
{
    Task<IEnumerable<TABLE5713Dto>> FindAsync(Expression<Func<TABLE5713, bool>> predicate);
}
