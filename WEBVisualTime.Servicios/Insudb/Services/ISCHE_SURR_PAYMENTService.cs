using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_PAYMENT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ISCHE_SURR_PAYMENTService : IService<SCHE_SURR_PAYMENTDto, CreateSCHE_SURR_PAYMENTDto, UpdateSCHE_SURR_PAYMENTDto, string>
{
    Task<IEnumerable<SCHE_SURR_PAYMENTDto>> FindAsync(Expression<Func<SCHE_SURR_PAYMENT, bool>> predicate);
}
