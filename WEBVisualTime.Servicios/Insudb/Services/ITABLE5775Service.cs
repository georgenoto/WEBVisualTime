using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5775;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5775Service : IService<TABLE5775Dto, CreateTABLE5775Dto, UpdateTABLE5775Dto, int>
{
    Task<IEnumerable<TABLE5775Dto>> FindAsync(Expression<Func<TABLE5775, bool>> predicate);
}
