using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5636Service : IService<TABLE5636Dto, CreateTABLE5636Dto, UpdateTABLE5636Dto, int>
{
    Task<IEnumerable<TABLE5636Dto>> FindAsync(Expression<Func<TABLE5636, bool>> predicate);
}
