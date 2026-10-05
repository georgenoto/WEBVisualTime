using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9247;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9247Service : IService<TABLE9247Dto, CreateTABLE9247Dto, UpdateTABLE9247Dto, int>
{
    Task<IEnumerable<TABLE9247Dto>> FindAsync(Expression<Func<TABLE9247, bool>> predicate);
}
