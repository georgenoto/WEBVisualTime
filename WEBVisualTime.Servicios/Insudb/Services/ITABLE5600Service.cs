using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5600;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5600Service : IService<TABLE5600Dto, CreateTABLE5600Dto, UpdateTABLE5600Dto, int>
{
    Task<IEnumerable<TABLE5600Dto>> FindAsync(Expression<Func<TABLE5600, bool>> predicate);
}
