using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7204;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7204Service : IService<TABLE7204Dto, CreateTABLE7204Dto, UpdateTABLE7204Dto, long>
{
    Task<IEnumerable<TABLE7204Dto>> FindAsync(Expression<Func<TABLE7204, bool>> predicate);
}
