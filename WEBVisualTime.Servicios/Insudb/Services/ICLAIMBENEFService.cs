using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIMBENEF;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLAIMBENEFService : IService<CLAIMBENEFDto, CreateCLAIMBENEFDto, UpdateCLAIMBENEFDto, long>
{
    Task<IEnumerable<CLAIMBENEFDto>> FindAsync(Expression<Func<CLAIMBENEF, bool>> predicate);
}
