using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNP_PAYS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTRNP_PAYSService : IService<CONTRNP_PAYSDto, CreateCONTRNP_PAYSDto, UpdateCONTRNP_PAYSDto, int>
{
    Task<IEnumerable<CONTRNP_PAYSDto>> FindAsync(Expression<Func<CONTRNP_PAYS, bool>> predicate);
}
