using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LED_COMPAN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILED_COMPANService : IService<LED_COMPANDto, CreateLED_COMPANDto, UpdateLED_COMPANDto, int>
{
    Task<IEnumerable<LED_COMPANDto>> FindAsync(Expression<Func<LED_COMPAN, bool>> predicate);
}
