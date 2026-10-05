using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILEDGER_ACCService : IService<LEDGER_ACCDto, CreateLEDGER_ACCDto, UpdateLEDGER_ACCDto, int>
{
    Task<IEnumerable<LEDGER_ACCDto>> FindAsync(Expression<Func<LEDGER_ACC, bool>> predicate);
}
