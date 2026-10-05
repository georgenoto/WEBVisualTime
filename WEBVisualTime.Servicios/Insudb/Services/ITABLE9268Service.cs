using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9268;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9268Service : IService<TABLE9268Dto, CreateTABLE9268Dto, UpdateTABLE9268Dto, int>
{
    Task<IEnumerable<TABLE9268Dto>> FindAsync(Expression<Func<TABLE9268, bool>> predicate);
}
