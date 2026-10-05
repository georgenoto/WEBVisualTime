using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5573;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5573Service : IService<TABLE5573Dto, CreateTABLE5573Dto, UpdateTABLE5573Dto, int>
{
    Task<IEnumerable<TABLE5573Dto>> FindAsync(Expression<Func<TABLE5573, bool>> predicate);
}
