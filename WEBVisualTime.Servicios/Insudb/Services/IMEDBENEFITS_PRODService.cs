using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDBENEFITS_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMEDBENEFITS_PRODService : IService<MEDBENEFITS_PRODDto, CreateMEDBENEFITS_PRODDto, UpdateMEDBENEFITS_PRODDto, string>
{
    Task<IEnumerable<MEDBENEFITS_PRODDto>> FindAsync(Expression<Func<MEDBENEFITS_PROD, bool>> predicate);
}
