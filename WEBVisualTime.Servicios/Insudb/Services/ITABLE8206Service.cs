using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8206Service : IService<TABLE8206Dto, CreateTABLE8206Dto, UpdateTABLE8206Dto, int>
{
    Task<IEnumerable<TABLE8206Dto>> FindAsync(Expression<Func<TABLE8206, bool>> predicate);
}
