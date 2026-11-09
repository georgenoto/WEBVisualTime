using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDICALFEES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_MEDICALFEESService : IService<TAB_MEDICALFEESDto, CreateTAB_MEDICALFEESDto, UpdateTAB_MEDICALFEESDto, string>
{
    Task<IEnumerable<TAB_MEDICALFEESDto>> FindAsync(Expression<Func<TAB_MEDICALFEES, bool>> predicate);
}
