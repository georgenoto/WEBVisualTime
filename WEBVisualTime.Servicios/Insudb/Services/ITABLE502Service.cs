using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE502;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE502Service : IService<TABLE502Dto, CreateTABLE502Dto, UpdateTABLE502Dto, long>
{
    Task<IEnumerable<TABLE502Dto>> FindAsync(Expression<Func<TABLE502, bool>> predicate);
}
