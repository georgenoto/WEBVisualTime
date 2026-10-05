using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DETAIL;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLORDER_DETAILService : IService<CLORDER_DETAILDto, CreateCLORDER_DETAILDto, UpdateCLORDER_DETAILDto, long>
{
    Task<IEnumerable<CLORDER_DETAILDto>> FindAsync(Expression<Func<CLORDER_DETAIL, bool>> predicate);
}
