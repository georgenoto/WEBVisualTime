using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_REASON;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_SURR_REASONService : IService<SCHE_SURR_REASONDto, CreateSCHE_SURR_REASONDto, UpdateSCHE_SURR_REASONDto, string>
{
    Task<IEnumerable<SCHE_SURR_REASONDto>> FindAsync(Expression<Func<SCHE_SURR_REASON, bool>> predicate);
}
