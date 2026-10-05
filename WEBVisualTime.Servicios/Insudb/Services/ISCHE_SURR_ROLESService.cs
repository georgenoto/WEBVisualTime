using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_ROLES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_SURR_ROLESService : IService<SCHE_SURR_ROLESDto, CreateSCHE_SURR_ROLESDto, UpdateSCHE_SURR_ROLESDto, string>
{
    Task<IEnumerable<SCHE_SURR_ROLESDto>> FindAsync(Expression<Func<SCHE_SURR_ROLES, bool>> predicate);
}
