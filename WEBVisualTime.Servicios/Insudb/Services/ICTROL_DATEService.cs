using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CTROL_DATE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICTROL_DATEService : IService<CTROL_DATEDto, CreateCTROL_DATEDto, UpdateCTROL_DATEDto, int>
{
    Task<IEnumerable<CTROL_DATEDto>> FindAsync(Expression<Func<CTROL_DATE, bool>> predicate);
}
