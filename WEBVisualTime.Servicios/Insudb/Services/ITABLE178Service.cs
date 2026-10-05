using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE178;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE178Service : IService<TABLE178Dto, CreateTABLE178Dto, UpdateTABLE178Dto, int>
{
    Task<IEnumerable<TABLE178Dto>> FindAsync(Expression<Func<TABLE178, bool>> predicate);
}
