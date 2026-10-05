using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CURREN_POL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICURREN_POLService : IService<CURREN_POLDto, CreateCURREN_POLDto, UpdateCURREN_POLDto, string>
{
    Task<IEnumerable<CURREN_POLDto>> FindAsync(Expression<Func<CURREN_POL, bool>> predicate);
}
