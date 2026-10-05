using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE258;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE258Service : IService<TABLE258Dto, CreateTABLE258Dto, UpdateTABLE258Dto, long>
{
    Task<IEnumerable<TABLE258Dto>> FindAsync(Expression<Func<TABLE258, bool>> predicate);
}
