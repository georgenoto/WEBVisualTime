using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE996;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE996Service : IService<TABLE996Dto, CreateTABLE996Dto, UpdateTABLE996Dto, int>
{
    Task<IEnumerable<TABLE996Dto>> FindAsync(Expression<Func<TABLE996, bool>> predicate);
}
