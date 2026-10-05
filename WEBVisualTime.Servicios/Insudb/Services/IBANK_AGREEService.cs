using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_AGREE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBANK_AGREEService : IService<BANK_AGREEDto, CreateBANK_AGREEDto, UpdateBANK_AGREEDto, string>
{
    Task<IEnumerable<BANK_AGREEDto>> FindAsync(Expression<Func<BANK_AGREE, bool>> predicate);
}
