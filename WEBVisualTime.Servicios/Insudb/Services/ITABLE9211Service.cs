using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9211;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9211Service : IService<TABLE9211Dto, CreateTABLE9211Dto, UpdateTABLE9211Dto, int>
{
    Task<IEnumerable<TABLE9211Dto>> FindAsync(Expression<Func<TABLE9211, bool>> predicate);
}
