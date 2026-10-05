using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7045;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7045Service : IService<TABLE7045Dto, CreateTABLE7045Dto, UpdateTABLE7045Dto, int>
{
    Task<IEnumerable<TABLE7045Dto>> FindAsync(Expression<Func<TABLE7045, bool>> predicate);
}
