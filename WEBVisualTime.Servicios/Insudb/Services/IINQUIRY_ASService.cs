using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INQUIRY_AS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINQUIRY_ASService : IService<INQUIRY_ASDto, CreateINQUIRY_ASDto, UpdateINQUIRY_ASDto, int>
{
    Task<IEnumerable<INQUIRY_ASDto>> FindAsync(Expression<Func<INQUIRY_AS, bool>> predicate);
}
