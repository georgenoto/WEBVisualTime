using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7000;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7000Service : IService<TABLE7000Dto, CreateTABLE7000Dto, UpdateTABLE7000Dto, int>
{
    Task<IEnumerable<TABLE7000Dto>> FindAsync(Expression<Func<TABLE7000, bool>> predicate);
}
