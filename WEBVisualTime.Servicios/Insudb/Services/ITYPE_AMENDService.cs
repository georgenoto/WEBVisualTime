using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPE_AMEND;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITYPE_AMENDService : IService<TYPE_AMENDDto, CreateTYPE_AMENDDto, UpdateTYPE_AMENDDto, int>
{
    Task<IEnumerable<TYPE_AMENDDto>> FindAsync(Expression<Func<TYPE_AMEND, bool>> predicate);
}
