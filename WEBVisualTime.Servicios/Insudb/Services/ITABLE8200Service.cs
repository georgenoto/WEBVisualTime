using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8200Service : IService<TABLE8200Dto, CreateTABLE8200Dto, UpdateTABLE8200Dto, int>
{
    Task<IEnumerable<TABLE8200Dto>> FindAsync(Expression<Func<TABLE8200, bool>> predicate);
}
