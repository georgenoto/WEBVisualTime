using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5008;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5008Service : IService<TABLE5008Dto, CreateTABLE5008Dto, UpdateTABLE5008Dto, long>
{
    Task<IEnumerable<TABLE5008Dto>> FindAsync(Expression<Func<TABLE5008, bool>> predicate);
}
