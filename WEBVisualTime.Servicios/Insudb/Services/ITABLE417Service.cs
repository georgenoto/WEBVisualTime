using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE417;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE417Service : IService<TABLE417Dto, CreateTABLE417Dto, UpdateTABLE417Dto, long>
{
    Task<IEnumerable<TABLE417Dto>> FindAsync(Expression<Func<TABLE417, bool>> predicate);
}
