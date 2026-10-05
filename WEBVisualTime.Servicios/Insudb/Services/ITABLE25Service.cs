using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE25Service : IService<TABLE25Dto, CreateTABLE25Dto, UpdateTABLE25Dto, string>
{
    Task<IEnumerable<TABLE25Dto>> FindAsync(Expression<Func<TABLE25, bool>> predicate);
}
