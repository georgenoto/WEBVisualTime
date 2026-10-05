using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE415;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE415Service : IService<TABLE415Dto, CreateTABLE415Dto, UpdateTABLE415Dto, int>
{
    Task<IEnumerable<TABLE415Dto>> FindAsync(Expression<Func<TABLE415, bool>> predicate);
}
