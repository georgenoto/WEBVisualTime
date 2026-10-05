using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLDOCREQ;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IROLDOCREQService : IService<ROLDOCREQDto, CreateROLDOCREQDto, UpdateROLDOCREQDto, int>
{
    Task<IEnumerable<ROLDOCREQDto>> FindAsync(Expression<Func<ROLDOCREQ, bool>> predicate);
}
