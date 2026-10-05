using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9270;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9270Service : IService<TABLE9270Dto, CreateTABLE9270Dto, UpdateTABLE9270Dto, long>
{
    Task<IEnumerable<TABLE9270Dto>> FindAsync(Expression<Func<TABLE9270, bool>> predicate);
}
