using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBANK_ACCService : IService<BANK_ACCDto, CreateBANK_ACCDto, UpdateBANK_ACCDto, int>
{
    Task<IEnumerable<BANK_ACCDto>> FindAsync(Expression<Func<BANK_ACC, bool>> predicate);
}
