using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9276;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9276Service : IService<TABLE9276Dto, CreateTABLE9276Dto, UpdateTABLE9276Dto, int>
{
    Task<IEnumerable<TABLE9276Dto>> FindAsync(Expression<Func<TABLE9276, bool>> predicate);
}
