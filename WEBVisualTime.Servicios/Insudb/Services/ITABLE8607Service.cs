using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8607;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8607Service : IService<TABLE8607Dto, CreateTABLE8607Dto, UpdateTABLE8607Dto, int>
{
    Task<IEnumerable<TABLE8607Dto>> FindAsync(Expression<Func<TABLE8607, bool>> predicate);
}
