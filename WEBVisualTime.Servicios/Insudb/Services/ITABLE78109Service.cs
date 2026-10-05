using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE78109Service : IService<TABLE78109Dto, CreateTABLE78109Dto, UpdateTABLE78109Dto, int>
{
    Task<IEnumerable<TABLE78109Dto>> FindAsync(Expression<Func<TABLE78109, bool>> predicate);
}
