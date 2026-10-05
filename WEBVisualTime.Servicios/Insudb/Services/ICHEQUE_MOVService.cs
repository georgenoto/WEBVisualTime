using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUE_MOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICHEQUE_MOVService : IService<CHEQUE_MOVDto, CreateCHEQUE_MOVDto, UpdateCHEQUE_MOVDto, int>
{
    Task<IEnumerable<CHEQUE_MOVDto>> FindAsync(Expression<Func<CHEQUE_MOV, bool>> predicate);
}
