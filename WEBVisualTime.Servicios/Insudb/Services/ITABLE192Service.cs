using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE192;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE192Service : IService<TABLE192Dto, CreateTABLE192Dto, UpdateTABLE192Dto, int>
{
    Task<IEnumerable<TABLE192Dto>> FindAsync(Expression<Func<TABLE192, bool>> predicate);
}
