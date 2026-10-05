using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT_AL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IAGREEMENT_ALService : IService<AGREEMENT_ALDto, CreateAGREEMENT_ALDto, UpdateAGREEMENT_ALDto, int>
{
    Task<IEnumerable<AGREEMENT_ALDto>> FindAsync(Expression<Func<AGREEMENT_AL, bool>> predicate);
}
