using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8019;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8019Service : IService<TABLE8019Dto, CreateTABLE8019Dto, UpdateTABLE8019Dto, int>
{
    Task<IEnumerable<TABLE8019Dto>> FindAsync(Expression<Func<TABLE8019, bool>> predicate);
}
