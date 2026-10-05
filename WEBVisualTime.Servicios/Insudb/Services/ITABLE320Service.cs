using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE320;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE320Service : IService<TABLE320Dto, CreateTABLE320Dto, UpdateTABLE320Dto, int>
{
    Task<IEnumerable<TABLE320Dto>> FindAsync(Expression<Func<TABLE320, bool>> predicate);
}
