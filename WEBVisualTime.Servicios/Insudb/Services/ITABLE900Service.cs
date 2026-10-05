using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE900;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE900Service : IService<TABLE900Dto, CreateTABLE900Dto, UpdateTABLE900Dto, long>
{
    Task<IEnumerable<TABLE900Dto>> FindAsync(Expression<Func<TABLE900, bool>> predicate);
}
