using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9235;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9235Service : IService<TABLE9235Dto, CreateTABLE9235Dto, UpdateTABLE9235Dto, string>
{
    Task<IEnumerable<TABLE9235Dto>> FindAsync(Expression<Func<TABLE9235, bool>> predicate);
}
