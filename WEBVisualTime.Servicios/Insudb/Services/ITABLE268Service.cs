using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE268;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE268Service : IService<TABLE268Dto, CreateTABLE268Dto, UpdateTABLE268Dto, int>
{
    Task<IEnumerable<TABLE268Dto>> FindAsync(Expression<Func<TABLE268, bool>> predicate);
}
