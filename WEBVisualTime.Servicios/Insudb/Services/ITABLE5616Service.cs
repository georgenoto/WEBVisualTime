using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5616;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5616Service : IService<TABLE5616Dto, CreateTABLE5616Dto, UpdateTABLE5616Dto, int>
{
    Task<IEnumerable<TABLE5616Dto>> FindAsync(Expression<Func<TABLE5616, bool>> predicate);
}
