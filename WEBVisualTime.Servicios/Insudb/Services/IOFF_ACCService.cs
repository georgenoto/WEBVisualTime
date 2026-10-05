using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OFF_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IOFF_ACCService : IService<OFF_ACCDto, CreateOFF_ACCDto, UpdateOFF_ACCDto, string>
{
    Task<IEnumerable<OFF_ACCDto>> FindAsync(Expression<Func<OFF_ACC, bool>> predicate);
}
