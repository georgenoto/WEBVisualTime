using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE127;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE127Service : IService<TABLE127Dto, CreateTABLE127Dto, UpdateTABLE127Dto, int>
{
    Task<IEnumerable<TABLE127Dto>> FindAsync(Expression<Func<TABLE127, bool>> predicate);
}
