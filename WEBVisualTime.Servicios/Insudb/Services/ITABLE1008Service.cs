using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1008;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE1008Service : IService<TABLE1008Dto, CreateTABLE1008Dto, UpdateTABLE1008Dto, int>
{
    Task<IEnumerable<TABLE1008Dto>> FindAsync(Expression<Func<TABLE1008, bool>> predicate);
}
