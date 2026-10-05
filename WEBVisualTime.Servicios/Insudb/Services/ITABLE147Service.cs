using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE147;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE147Service : IService<TABLE147Dto, CreateTABLE147Dto, UpdateTABLE147Dto, int>
{
    Task<IEnumerable<TABLE147Dto>> FindAsync(Expression<Func<TABLE147, bool>> predicate);
}
