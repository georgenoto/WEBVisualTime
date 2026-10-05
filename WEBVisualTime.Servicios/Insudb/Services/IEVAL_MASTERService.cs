using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IEVAL_MASTERService : IService<EVAL_MASTERDto, CreateEVAL_MASTERDto, UpdateEVAL_MASTERDto, long>
{
    Task<IEnumerable<EVAL_MASTERDto>> FindAsync(Expression<Func<EVAL_MASTER, bool>> predicate);
}
