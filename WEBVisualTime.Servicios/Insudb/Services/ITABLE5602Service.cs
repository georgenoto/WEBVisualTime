using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5602Service : IService<TABLE5602Dto, CreateTABLE5602Dto, UpdateTABLE5602Dto, string>
{
    Task<IEnumerable<TABLE5602Dto>> FindAsync(Expression<Func<TABLE5602, bool>> predicate);
}
