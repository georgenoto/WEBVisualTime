using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE205;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE205Service : IService<TABLE205Dto, CreateTABLE205Dto, UpdateTABLE205Dto, int>
{
    Task<IEnumerable<TABLE205Dto>> FindAsync(Expression<Func<TABLE205, bool>> predicate);
}
