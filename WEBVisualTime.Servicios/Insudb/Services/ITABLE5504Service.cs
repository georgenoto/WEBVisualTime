using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5504Service : IService<TABLE5504Dto, CreateTABLE5504Dto, UpdateTABLE5504Dto, int>
{
    Task<IEnumerable<TABLE5504Dto>> FindAsync(Expression<Func<TABLE5504, bool>> predicate);
}
