using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALFEES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDICALFEESService : IService<MEDICALFEESDto, CreateMEDICALFEESDto, UpdateMEDICALFEESDto, string>
{
    Task<IEnumerable<MEDICALFEESDto>> FindAsync(Expression<Func<MEDICALFEES, bool>> predicate);
}
