using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8205Service : IService<TABLE8205Dto, CreateTABLE8205Dto, UpdateTABLE8205Dto, int>
{
    Task<IEnumerable<TABLE8205Dto>> FindAsync(Expression<Func<TABLE8205, bool>> predicate);
}
