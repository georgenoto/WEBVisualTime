using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_GROUP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBENEFITS_GROUPService : IService<BENEFITS_GROUPDto, CreateBENEFITS_GROUPDto, UpdateBENEFITS_GROUPDto, string>
{
    Task<IEnumerable<BENEFITS_GROUPDto>> FindAsync(Expression<Func<BENEFITS_GROUP, bool>> predicate);
}
