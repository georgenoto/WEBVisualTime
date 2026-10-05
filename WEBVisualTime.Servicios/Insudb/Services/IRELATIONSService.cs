using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRELATIONSService : IService<RELATIONSDto, CreateRELATIONSDto, UpdateRELATIONSDto, string>
{
    Task<IEnumerable<RELATIONSDto>> FindAsync(Expression<Func<RELATIONS, bool>> predicate);
}
