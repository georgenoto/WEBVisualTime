using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE108;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE108Service : IService<TABLE108Dto, CreateTABLE108Dto, UpdateTABLE108Dto, string>
{
    Task<IEnumerable<TABLE108Dto>> FindAsync(Expression<Func<TABLE108, bool>> predicate);
}
