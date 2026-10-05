using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBENEFITS_CATEGORYService : IService<BENEFITS_CATEGORYDto, CreateBENEFITS_CATEGORYDto, UpdateBENEFITS_CATEGORYDto, int>
{
    Task<IEnumerable<BENEFITS_CATEGORYDto>> FindAsync(Expression<Func<BENEFITS_CATEGORY, bool>> predicate);
}
