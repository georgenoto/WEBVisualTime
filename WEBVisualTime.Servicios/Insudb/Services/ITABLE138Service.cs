using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE138;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE138Service : IService<TABLE138Dto, CreateTABLE138Dto, UpdateTABLE138Dto, int>
{
    Task<IEnumerable<TABLE138Dto>> FindAsync(Expression<Func<TABLE138, bool>> predicate);
}
