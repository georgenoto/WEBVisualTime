using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INSURED_EXPDIS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IINSURED_EXPDISService : IService<INSURED_EXPDISDto, CreateINSURED_EXPDISDto, UpdateINSURED_EXPDISDto, string>
{
    Task<IEnumerable<INSURED_EXPDISDto>> FindAsync(Expression<Func<INSURED_EXPDIS, bool>> predicate);
}
