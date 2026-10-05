using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7210Service : IService<TABLE7210Dto, CreateTABLE7210Dto, UpdateTABLE7210Dto, int>
{
    Task<IEnumerable<TABLE7210Dto>> FindAsync(Expression<Func<TABLE7210, bool>> predicate);
}
