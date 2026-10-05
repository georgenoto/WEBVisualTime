using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISECUR_SCHEService : IService<SECUR_SCHEDto, CreateSECUR_SCHEDto, UpdateSECUR_SCHEDto, string>
{
    Task<IEnumerable<SECUR_SCHEDto>> FindAsync(Expression<Func<SECUR_SCHE, bool>> predicate);
}
