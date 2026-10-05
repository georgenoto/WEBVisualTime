using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONSHIP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IRELATIONSHIPService : IService<RELATIONSHIPDto, CreateRELATIONSHIPDto, UpdateRELATIONSHIPDto, int>
{
    Task<IEnumerable<RELATIONSHIPDto>> FindAsync(Expression<Func<RELATIONSHIP, bool>> predicate);
}
