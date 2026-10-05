using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOLLIDAYS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IHOLLIDAYSService : IService<HOLLIDAYSDto, CreateHOLLIDAYSDto, UpdateHOLLIDAYSDto, long>
{
    Task<IEnumerable<HOLLIDAYSDto>> FindAsync(Expression<Func<HOLLIDAYS, bool>> predicate);
}
