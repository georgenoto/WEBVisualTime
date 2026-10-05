using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3019;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE3019Service : IService<TABLE3019Dto, CreateTABLE3019Dto, UpdateTABLE3019Dto, int>
{
    Task<IEnumerable<TABLE3019Dto>> FindAsync(Expression<Func<TABLE3019, bool>> predicate);
}
