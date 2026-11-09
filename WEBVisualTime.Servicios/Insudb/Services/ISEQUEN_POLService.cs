using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQUEN_POL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISEQUEN_POLService : IService<SEQUEN_POLDto, CreateSEQUEN_POLDto, UpdateSEQUEN_POLDto, string>
{
    Task<IEnumerable<SEQUEN_POLDto>> FindAsync(Expression<Func<SEQUEN_POL, bool>> predicate);
}
