using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7211;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7211Service : IService<TABLE7211Dto, CreateTABLE7211Dto, UpdateTABLE7211Dto, int>
{
    Task<IEnumerable<TABLE7211Dto>> FindAsync(Expression<Func<TABLE7211, bool>> predicate);
}
