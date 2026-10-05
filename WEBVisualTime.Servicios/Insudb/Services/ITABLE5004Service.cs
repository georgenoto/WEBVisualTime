using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5004;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5004Service : IService<TABLE5004Dto, CreateTABLE5004Dto, UpdateTABLE5004Dto, int>
{
    Task<IEnumerable<TABLE5004Dto>> FindAsync(Expression<Func<TABLE5004, bool>> predicate);
}
