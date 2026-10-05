using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE636;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE636Service : IService<TABLE636Dto, CreateTABLE636Dto, UpdateTABLE636Dto, long>
{
    Task<IEnumerable<TABLE636Dto>> FindAsync(Expression<Func<TABLE636, bool>> predicate);
}
