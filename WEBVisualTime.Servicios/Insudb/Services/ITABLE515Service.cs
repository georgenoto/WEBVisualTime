using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE515;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE515Service : IService<TABLE515Dto, CreateTABLE515Dto, UpdateTABLE515Dto, long>
{
    Task<IEnumerable<TABLE515Dto>> FindAsync(Expression<Func<TABLE515, bool>> predicate);
}
