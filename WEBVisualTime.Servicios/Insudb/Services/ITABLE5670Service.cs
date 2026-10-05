using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5670;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5670Service : IService<TABLE5670Dto, CreateTABLE5670Dto, UpdateTABLE5670Dto, int>
{
    Task<IEnumerable<TABLE5670Dto>> FindAsync(Expression<Func<TABLE5670, bool>> predicate);
}
