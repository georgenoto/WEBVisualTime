using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE11Service : IService<TABLE11Dto, CreateTABLE11Dto, UpdateTABLE11Dto, long>
{
    Task<IEnumerable<TABLE11Dto>> FindAsync(Expression<Func<TABLE11, bool>> predicate);
}
