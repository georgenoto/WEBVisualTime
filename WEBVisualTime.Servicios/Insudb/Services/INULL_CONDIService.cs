using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NULL_CONDI;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INULL_CONDIService : IService<NULL_CONDIDto, CreateNULL_CONDIDto, UpdateNULL_CONDIDto, string>
{
    Task<IEnumerable<NULL_CONDIDto>> FindAsync(Expression<Func<NULL_CONDI, bool>> predicate);
}
