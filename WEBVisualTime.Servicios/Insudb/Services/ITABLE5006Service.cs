using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5006;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5006Service : IService<TABLE5006Dto, CreateTABLE5006Dto, UpdateTABLE5006Dto, int>
{
    Task<IEnumerable<TABLE5006Dto>> FindAsync(Expression<Func<TABLE5006, bool>> predicate);
}
