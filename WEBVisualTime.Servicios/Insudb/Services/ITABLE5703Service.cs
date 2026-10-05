using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5703;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5703Service : IService<TABLE5703Dto, CreateTABLE5703Dto, UpdateTABLE5703Dto, int>
{
    Task<IEnumerable<TABLE5703Dto>> FindAsync(Expression<Func<TABLE5703, bool>> predicate);
}
