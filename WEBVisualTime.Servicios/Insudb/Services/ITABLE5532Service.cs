using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5532Service : IService<TABLE5532Dto, CreateTABLE5532Dto, UpdateTABLE5532Dto, int>
{
    Task<IEnumerable<TABLE5532Dto>> FindAsync(Expression<Func<TABLE5532, bool>> predicate);
}
