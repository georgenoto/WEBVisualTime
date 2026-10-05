using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9004;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9004Service : IService<TABLE9004Dto, CreateTABLE9004Dto, UpdateTABLE9004Dto, int>
{
    Task<IEnumerable<TABLE9004Dto>> FindAsync(Expression<Func<TABLE9004, bool>> predicate);
}
