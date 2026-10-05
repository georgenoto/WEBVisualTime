using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9275Service : IService<TABLE9275Dto, CreateTABLE9275Dto, UpdateTABLE9275Dto, int>
{
    Task<IEnumerable<TABLE9275Dto>> FindAsync(Expression<Func<TABLE9275, bool>> predicate);
}
