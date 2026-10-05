using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5640;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5640Service : IService<TABLE5640Dto, CreateTABLE5640Dto, UpdateTABLE5640Dto, int>
{
    Task<IEnumerable<TABLE5640Dto>> FindAsync(Expression<Func<TABLE5640, bool>> predicate);
}
