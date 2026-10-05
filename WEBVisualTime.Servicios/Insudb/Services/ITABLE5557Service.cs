using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5557;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5557Service : IService<TABLE5557Dto, CreateTABLE5557Dto, UpdateTABLE5557Dto, int>
{
    Task<IEnumerable<TABLE5557Dto>> FindAsync(Expression<Func<TABLE5557, bool>> predicate);
}
