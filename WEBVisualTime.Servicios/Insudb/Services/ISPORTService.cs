using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SPORT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISPORTService : IService<SPORTDto, CreateSPORTDto, UpdateSPORTDto, string>
{
    Task<IEnumerable<SPORTDto>> FindAsync(Expression<Func<SPORT, bool>> predicate);
}
