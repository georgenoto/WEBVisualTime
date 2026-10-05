using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE296;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE296Service : IService<TABLE296Dto, CreateTABLE296Dto, UpdateTABLE296Dto, int>
{
    Task<IEnumerable<TABLE296Dto>> FindAsync(Expression<Func<TABLE296, bool>> predicate);
}
