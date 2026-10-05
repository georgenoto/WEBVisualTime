using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9012;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9012Service : IService<TABLE9012Dto, CreateTABLE9012Dto, UpdateTABLE9012Dto, int>
{
    Task<IEnumerable<TABLE9012Dto>> FindAsync(Expression<Func<TABLE9012, bool>> predicate);
}
