using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE532;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE532Service : IService<TABLE532Dto, CreateTABLE532Dto, UpdateTABLE532Dto, int>
{
    Task<IEnumerable<TABLE532Dto>> FindAsync(Expression<Func<TABLE532, bool>> predicate);
}
