using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPESUBTYPE_RELATIONSHIP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITYPESUBTYPE_RELATIONSHIPService : IService<TYPESUBTYPE_RELATIONSHIPDto, CreateTYPESUBTYPE_RELATIONSHIPDto, UpdateTYPESUBTYPE_RELATIONSHIPDto, string>
{
    Task<IEnumerable<TYPESUBTYPE_RELATIONSHIPDto>> FindAsync(Expression<Func<TYPESUBTYPE_RELATIONSHIP, bool>> predicate);
}
