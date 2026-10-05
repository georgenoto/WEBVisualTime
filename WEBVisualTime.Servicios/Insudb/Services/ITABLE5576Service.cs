using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5576Service : IService<TABLE5576Dto, CreateTABLE5576Dto, UpdateTABLE5576Dto, int>
{
    Task<IEnumerable<TABLE5576Dto>> FindAsync(Expression<Func<TABLE5576, bool>> predicate);
}
