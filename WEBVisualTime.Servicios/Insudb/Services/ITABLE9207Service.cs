using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9207Service : IService<TABLE9207Dto, CreateTABLE9207Dto, UpdateTABLE9207Dto, int>
{
    Task<IEnumerable<TABLE9207Dto>> FindAsync(Expression<Func<TABLE9207, bool>> predicate);
}
