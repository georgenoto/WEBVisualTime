using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7212;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7212Service : IService<TABLE7212Dto, CreateTABLE7212Dto, UpdateTABLE7212Dto, int>
{
    Task<IEnumerable<TABLE7212Dto>> FindAsync(Expression<Func<TABLE7212, bool>> predicate);
}
