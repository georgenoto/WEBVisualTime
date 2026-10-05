using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPERSON_TYPEService : IService<PERSON_TYPEDto, CreatePERSON_TYPEDto, UpdatePERSON_TYPEDto, long>
{
    Task<IEnumerable<PERSON_TYPEDto>> FindAsync(Expression<Func<PERSON_TYPE, bool>> predicate);
}
