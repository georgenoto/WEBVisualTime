using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE141;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE141Service : IService<TABLE141Dto, CreateTABLE141Dto, UpdateTABLE141Dto, int>
{
    Task<IEnumerable<TABLE141Dto>> FindAsync(Expression<Func<TABLE141, bool>> predicate);
}
