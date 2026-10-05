using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE291;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE291Service : IService<TABLE291Dto, CreateTABLE291Dto, UpdateTABLE291Dto, string>
{
    Task<IEnumerable<TABLE291Dto>> FindAsync(Expression<Func<TABLE291, bool>> predicate);
}
