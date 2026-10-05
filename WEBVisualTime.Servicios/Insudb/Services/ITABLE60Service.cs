using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE60;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE60Service : IService<TABLE60Dto, CreateTABLE60Dto, UpdateTABLE60Dto, long>
{
    Task<IEnumerable<TABLE60Dto>> FindAsync(Expression<Func<TABLE60, bool>> predicate);
}
