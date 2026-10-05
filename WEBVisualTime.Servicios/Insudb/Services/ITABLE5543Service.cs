using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5543;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5543Service : IService<TABLE5543Dto, CreateTABLE5543Dto, UpdateTABLE5543Dto, int>
{
    Task<IEnumerable<TABLE5543Dto>> FindAsync(Expression<Func<TABLE5543, bool>> predicate);
}
