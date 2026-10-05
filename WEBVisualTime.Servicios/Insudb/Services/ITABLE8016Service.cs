using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8016;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8016Service : IService<TABLE8016Dto, CreateTABLE8016Dto, UpdateTABLE8016Dto, int>
{
    Task<IEnumerable<TABLE8016Dto>> FindAsync(Expression<Func<TABLE8016, bool>> predicate);
}
