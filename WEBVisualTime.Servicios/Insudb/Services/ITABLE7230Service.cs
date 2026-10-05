using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7230;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7230Service : IService<TABLE7230Dto, CreateTABLE7230Dto, UpdateTABLE7230Dto, int>
{
    Task<IEnumerable<TABLE7230Dto>> FindAsync(Expression<Func<TABLE7230, bool>> predicate);
}
