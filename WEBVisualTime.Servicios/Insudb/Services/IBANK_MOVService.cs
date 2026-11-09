using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_MOV;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBANK_MOVService : IService<BANK_MOVDto, CreateBANK_MOVDto, UpdateBANK_MOVDto, string>
{
    Task<IEnumerable<BANK_MOVDto>> FindAsync(Expression<Func<BANK_MOV, bool>> predicate);
}
