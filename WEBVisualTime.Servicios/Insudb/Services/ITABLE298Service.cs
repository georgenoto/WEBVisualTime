using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE298;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE298Service : IService<TABLE298Dto, CreateTABLE298Dto, UpdateTABLE298Dto, int>
{
    Task<IEnumerable<TABLE298Dto>> FindAsync(Expression<Func<TABLE298, bool>> predicate);
}
