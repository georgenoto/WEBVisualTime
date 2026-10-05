using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE275Service : IService<TABLE275Dto, CreateTABLE275Dto, UpdateTABLE275Dto, int>
{
    Task<IEnumerable<TABLE275Dto>> FindAsync(Expression<Func<TABLE275, bool>> predicate);
}
