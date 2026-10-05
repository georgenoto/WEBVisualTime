using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE13Service : IService<TABLE13Dto, CreateTABLE13Dto, UpdateTABLE13Dto, int>
{
    Task<IEnumerable<TABLE13Dto>> FindAsync(Expression<Func<TABLE13, bool>> predicate);
}
