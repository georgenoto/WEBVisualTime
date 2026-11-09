using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IT_DOCTYPService : IService<T_DOCTYPDto, CreateT_DOCTYPDto, UpdateT_DOCTYPDto, string>
{
    Task<IEnumerable<T_DOCTYPDto>> FindAsync(Expression<Func<T_DOCTYP, bool>> predicate);
}
