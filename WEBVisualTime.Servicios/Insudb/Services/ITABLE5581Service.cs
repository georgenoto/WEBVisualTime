using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5581;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5581Service : IService<TABLE5581Dto, CreateTABLE5581Dto, UpdateTABLE5581Dto, int>
{
    Task<IEnumerable<TABLE5581Dto>> FindAsync(Expression<Func<TABLE5581, bool>> predicate);
}
