using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE998;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE998Service : IService<TABLE998Dto, CreateTABLE998Dto, UpdateTABLE998Dto, int>
{
    Task<IEnumerable<TABLE998Dto>> FindAsync(Expression<Func<TABLE998, bool>> predicate);
}
