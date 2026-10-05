using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE77;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE77Service : IService<TABLE77Dto, CreateTABLE77Dto, UpdateTABLE77Dto, int>
{
    Task<IEnumerable<TABLE77Dto>> FindAsync(Expression<Func<TABLE77, bool>> predicate);
}
