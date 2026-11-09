using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.APV_LED_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IAPV_LED_ACCService : IService<APV_LED_ACCDto, CreateAPV_LED_ACCDto, UpdateAPV_LED_ACCDto, string>
{
    Task<IEnumerable<APV_LED_ACCDto>> FindAsync(Expression<Func<APV_LED_ACC, bool>> predicate);
}
