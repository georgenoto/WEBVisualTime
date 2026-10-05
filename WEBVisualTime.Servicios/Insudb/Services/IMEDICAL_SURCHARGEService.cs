using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDICAL_SURCHARGEService : IService<MEDICAL_SURCHARGEDto, CreateMEDICAL_SURCHARGEDto, UpdateMEDICAL_SURCHARGEDto, int>
{
    Task<IEnumerable<MEDICAL_SURCHARGEDto>> FindAsync(Expression<Func<MEDICAL_SURCHARGE, bool>> predicate);
}
