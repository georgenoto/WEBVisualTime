using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE55;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE55Service : IService<TABLE55Dto, CreateTABLE55Dto, UpdateTABLE55Dto, int>
{
    Task<IEnumerable<TABLE55Dto>> FindAsync(Expression<Func<TABLE55, bool>> predicate);
}
