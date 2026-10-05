using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALBENEFITS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDICALBENEFITSService : IService<MEDICALBENEFITSDto, CreateMEDICALBENEFITSDto, UpdateMEDICALBENEFITSDto, string>
{
    Task<IEnumerable<MEDICALBENEFITSDto>> FindAsync(Expression<Func<MEDICALBENEFITS, bool>> predicate);
}
