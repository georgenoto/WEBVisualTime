using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5750;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5750Service : IService<TABLE5750Dto, CreateTABLE5750Dto, UpdateTABLE5750Dto, string>
{
    Task<IEnumerable<TABLE5750Dto>> FindAsync(Expression<Func<TABLE5750, bool>> predicate);
}
