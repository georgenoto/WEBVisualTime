using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8502;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8502Service : IService<TABLE8502Dto, CreateTABLE8502Dto, UpdateTABLE8502Dto, int>
{
    Task<IEnumerable<TABLE8502Dto>> FindAsync(Expression<Func<TABLE8502, bool>> predicate);
}
