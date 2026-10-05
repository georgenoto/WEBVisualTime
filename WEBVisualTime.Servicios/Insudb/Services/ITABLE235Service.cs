using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE235;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE235Service : IService<TABLE235Dto, CreateTABLE235Dto, UpdateTABLE235Dto, string>
{
    Task<IEnumerable<TABLE235Dto>> FindAsync(Expression<Func<TABLE235, bool>> predicate);
}
