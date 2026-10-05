using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE157;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE157Service : IService<TABLE157Dto, CreateTABLE157Dto, UpdateTABLE157Dto, long>
{
    Task<IEnumerable<TABLE157Dto>> FindAsync(Expression<Func<TABLE157, bool>> predicate);
}
