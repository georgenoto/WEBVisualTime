using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IGROUPSService : IService<GROUPSDto, CreateGROUPSDto, UpdateGROUPSDto, string>
{
    Task<IEnumerable<GROUPSDto>> FindAsync(Expression<Func<GROUPS, bool>> predicate);
}
