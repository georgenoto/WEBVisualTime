using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5580Service : IService<TABLE5580Dto, CreateTABLE5580Dto, UpdateTABLE5580Dto, int>
{
    Task<IEnumerable<TABLE5580Dto>> FindAsync(Expression<Func<TABLE5580, bool>> predicate);
}
