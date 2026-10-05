using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE140Service : IService<TABLE140Dto, CreateTABLE140Dto, UpdateTABLE140Dto, int>
{
    Task<IEnumerable<TABLE140Dto>> FindAsync(Expression<Func<TABLE140, bool>> predicate);
}
