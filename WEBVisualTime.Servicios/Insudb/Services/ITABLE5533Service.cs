using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5533;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5533Service : IService<TABLE5533Dto, CreateTABLE5533Dto, UpdateTABLE5533Dto, int>
{
    Task<IEnumerable<TABLE5533Dto>> FindAsync(Expression<Func<TABLE5533, bool>> predicate);
}
