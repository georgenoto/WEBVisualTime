using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE180;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE180Service : IService<TABLE180Dto, CreateTABLE180Dto, UpdateTABLE180Dto, long>
{
    Task<IEnumerable<TABLE180Dto>> FindAsync(Expression<Func<TABLE180, bool>> predicate);
}
