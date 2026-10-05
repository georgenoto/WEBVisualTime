using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5741;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5741Service : IService<TABLE5741Dto, CreateTABLE5741Dto, UpdateTABLE5741Dto, int>
{
    Task<IEnumerable<TABLE5741Dto>> FindAsync(Expression<Func<TABLE5741, bool>> predicate);
}
