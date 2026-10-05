using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9212Service : IService<TABLE9212Dto, CreateTABLE9212Dto, UpdateTABLE9212Dto, int>
{
    Task<IEnumerable<TABLE9212Dto>> FindAsync(Expression<Func<TABLE9212, bool>> predicate);
}
