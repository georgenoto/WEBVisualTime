using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5545;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5545Service : IService<TABLE5545Dto, CreateTABLE5545Dto, UpdateTABLE5545Dto, int>
{
    Task<IEnumerable<TABLE5545Dto>> FindAsync(Expression<Func<TABLE5545, bool>> predicate);
}
