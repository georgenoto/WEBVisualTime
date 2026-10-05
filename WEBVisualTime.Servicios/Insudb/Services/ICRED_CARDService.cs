using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CRED_CARD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICRED_CARDService : IService<CRED_CARDDto, CreateCRED_CARDDto, UpdateCRED_CARDDto, string>
{
    Task<IEnumerable<CRED_CARDDto>> FindAsync(Expression<Func<CRED_CARD, bool>> predicate);
}
