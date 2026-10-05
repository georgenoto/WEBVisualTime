using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9014;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9014Service : IService<TABLE9014Dto, CreateTABLE9014Dto, UpdateTABLE9014Dto, int>
{
    Task<IEnumerable<TABLE9014Dto>> FindAsync(Expression<Func<TABLE9014, bool>> predicate);
}
