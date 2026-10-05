using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7006;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7006Service : IService<TABLE7006Dto, CreateTABLE7006Dto, UpdateTABLE7006Dto, long>
{
    Task<IEnumerable<TABLE7006Dto>> FindAsync(Expression<Func<TABLE7006, bool>> predicate);
}
