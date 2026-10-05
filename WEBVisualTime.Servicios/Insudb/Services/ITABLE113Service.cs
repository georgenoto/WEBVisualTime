using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE113;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE113Service : IService<TABLE113Dto, CreateTABLE113Dto, UpdateTABLE113Dto, int>
{
    Task<IEnumerable<TABLE113Dto>> FindAsync(Expression<Func<TABLE113, bool>> predicate);
}
