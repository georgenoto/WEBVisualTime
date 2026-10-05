using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE239;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE239Service : IService<TABLE239Dto, CreateTABLE239Dto, UpdateTABLE239Dto, int>
{
    Task<IEnumerable<TABLE239Dto>> FindAsync(Expression<Func<TABLE239, bool>> predicate);
}
