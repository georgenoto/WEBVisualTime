using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9236;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9236Service : IService<TABLE9236Dto, CreateTABLE9236Dto, UpdateTABLE9236Dto, int>
{
    Task<IEnumerable<TABLE9236Dto>> FindAsync(Expression<Func<TABLE9236, bool>> predicate);
}
