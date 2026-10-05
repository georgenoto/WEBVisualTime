using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_EVAL_ROL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDICAL_EVAL_ROLService : IService<MEDICAL_EVAL_ROLDto, CreateMEDICAL_EVAL_ROLDto, UpdateMEDICAL_EVAL_ROLDto, string>
{
    Task<IEnumerable<MEDICAL_EVAL_ROLDto>> FindAsync(Expression<Func<MEDICAL_EVAL_ROL, bool>> predicate);
}
