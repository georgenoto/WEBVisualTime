using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE289;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE289Service : IService<TABLE289Dto, CreateTABLE289Dto, UpdateTABLE289Dto, long>
{
    Task<IEnumerable<TABLE289Dto>> FindAsync(Expression<Func<TABLE289, bool>> predicate);
}
