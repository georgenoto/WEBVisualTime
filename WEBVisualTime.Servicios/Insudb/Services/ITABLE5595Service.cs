using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5595;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5595Service : IService<TABLE5595Dto, CreateTABLE5595Dto, UpdateTABLE5595Dto, int>
{
    Task<IEnumerable<TABLE5595Dto>> FindAsync(Expression<Func<TABLE5595, bool>> predicate);
}
