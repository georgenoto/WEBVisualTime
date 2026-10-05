using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE_SURR;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISECUR_SCHE_SURRService : IService<SECUR_SCHE_SURRDto, CreateSECUR_SCHE_SURRDto, UpdateSECUR_SCHE_SURRDto, string>
{
    Task<IEnumerable<SECUR_SCHE_SURRDto>> FindAsync(Expression<Func<SECUR_SCHE_SURR, bool>> predicate);
}
