using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5607;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5607Service : IService<TABLE5607Dto, CreateTABLE5607Dto, UpdateTABLE5607Dto, int>
{
    Task<IEnumerable<TABLE5607Dto>> FindAsync(Expression<Func<TABLE5607, bool>> predicate);
}
