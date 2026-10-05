using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE190Service : IService<TABLE190Dto, CreateTABLE190Dto, UpdateTABLE190Dto, int>
{
    Task<IEnumerable<TABLE190Dto>> FindAsync(Expression<Func<TABLE190, bool>> predicate);
}
