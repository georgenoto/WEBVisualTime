using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8602;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8602Service : IService<TABLE8602Dto, CreateTABLE8602Dto, UpdateTABLE8602Dto, string>
{
    Task<IEnumerable<TABLE8602Dto>> FindAsync(Expression<Func<TABLE8602, bool>> predicate);
}
