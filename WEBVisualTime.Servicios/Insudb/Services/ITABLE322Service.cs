using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE322;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE322Service : IService<TABLE322Dto, CreateTABLE322Dto, UpdateTABLE322Dto, int>
{
    Task<IEnumerable<TABLE322Dto>> FindAsync(Expression<Func<TABLE322, bool>> predicate);
}
