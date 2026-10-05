using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5520;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5520Service : IService<TABLE5520Dto, CreateTABLE5520Dto, UpdateTABLE5520Dto, int>
{
    Task<IEnumerable<TABLE5520Dto>> FindAsync(Expression<Func<TABLE5520, bool>> predicate);
}
