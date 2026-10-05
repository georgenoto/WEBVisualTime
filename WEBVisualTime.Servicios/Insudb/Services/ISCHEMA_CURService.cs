using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_CUR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHEMA_CURService : IService<SCHEMA_CURDto, CreateSCHEMA_CURDto, UpdateSCHEMA_CURDto, string>
{
    Task<IEnumerable<SCHEMA_CURDto>> FindAsync(Expression<Func<SCHEMA_CUR, bool>> predicate);
}
