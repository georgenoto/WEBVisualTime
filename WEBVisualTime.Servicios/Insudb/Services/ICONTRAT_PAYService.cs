using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRAT_PAY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTRAT_PAYService : IService<CONTRAT_PAYDto, CreateCONTRAT_PAYDto, UpdateCONTRAT_PAYDto, string>
{
    Task<IEnumerable<CONTRAT_PAYDto>> FindAsync(Expression<Func<CONTRAT_PAY, bool>> predicate);
}
