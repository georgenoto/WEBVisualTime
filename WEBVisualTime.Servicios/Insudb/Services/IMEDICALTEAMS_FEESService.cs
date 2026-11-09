using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALTEAMS_FEES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDICALTEAMS_FEESService : IService<MEDICALTEAMS_FEESDto, CreateMEDICALTEAMS_FEESDto, UpdateMEDICALTEAMS_FEESDto, string>
{
    Task<IEnumerable<MEDICALTEAMS_FEESDto>> FindAsync(Expression<Func<MEDICALTEAMS_FEES, bool>> predicate);
}
