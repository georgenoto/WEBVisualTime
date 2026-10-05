using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5744;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5744Service : IService<TABLE5744Dto, CreateTABLE5744Dto, UpdateTABLE5744Dto, int>
{
    Task<IEnumerable<TABLE5744Dto>> FindAsync(Expression<Func<TABLE5744, bool>> predicate);
}
