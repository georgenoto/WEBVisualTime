using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8005;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8005Service : IService<TABLE8005Dto, CreateTABLE8005Dto, UpdateTABLE8005Dto, int>
{
    Task<IEnumerable<TABLE8005Dto>> FindAsync(Expression<Func<TABLE8005, bool>> predicate);
}
