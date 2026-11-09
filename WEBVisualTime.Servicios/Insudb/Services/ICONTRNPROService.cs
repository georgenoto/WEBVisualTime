using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNPRO;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICONTRNPROService : IService<CONTRNPRODto, CreateCONTRNPRODto, UpdateCONTRNPRODto, string>
{
    Task<IEnumerable<CONTRNPRODto>> FindAsync(Expression<Func<CONTRNPRO, bool>> predicate);
}
