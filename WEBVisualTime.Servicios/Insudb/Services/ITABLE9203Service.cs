using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9203Service : IService<TABLE9203Dto, CreateTABLE9203Dto, UpdateTABLE9203Dto, int>
{
    Task<IEnumerable<TABLE9203Dto>> FindAsync(Expression<Func<TABLE9203, bool>> predicate);
}
