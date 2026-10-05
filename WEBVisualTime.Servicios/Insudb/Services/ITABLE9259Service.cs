using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9259;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9259Service : IService<TABLE9259Dto, CreateTABLE9259Dto, UpdateTABLE9259Dto, int>
{
    Task<IEnumerable<TABLE9259Dto>> FindAsync(Expression<Func<TABLE9259, bool>> predicate);
}
