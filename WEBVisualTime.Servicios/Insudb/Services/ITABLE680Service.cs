using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE680;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE680Service : IService<TABLE680Dto, CreateTABLE680Dto, UpdateTABLE680Dto, int>
{
    Task<IEnumerable<TABLE680Dto>> FindAsync(Expression<Func<TABLE680, bool>> predicate);
}
