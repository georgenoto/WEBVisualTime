using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE24Service : IService<TABLE24Dto, CreateTABLE24Dto, UpdateTABLE24Dto, int>
{
    Task<IEnumerable<TABLE24Dto>> FindAsync(Expression<Func<TABLE24, bool>> predicate);
}
