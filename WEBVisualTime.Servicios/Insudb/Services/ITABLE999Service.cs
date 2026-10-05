using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE999Service : IService<TABLE999Dto, CreateTABLE999Dto, UpdateTABLE999Dto, string>
{
    Task<IEnumerable<TABLE999Dto>> FindAsync(Expression<Func<TABLE999, bool>> predicate);
}
