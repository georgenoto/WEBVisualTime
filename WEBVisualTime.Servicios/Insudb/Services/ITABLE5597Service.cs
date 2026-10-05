using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5597;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5597Service : IService<TABLE5597Dto, CreateTABLE5597Dto, UpdateTABLE5597Dto, int>
{
    Task<IEnumerable<TABLE5597Dto>> FindAsync(Expression<Func<TABLE5597, bool>> predicate);
}
