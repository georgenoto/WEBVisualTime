using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICL_COMMERTYPEPAYService : IService<CL_COMMERTYPEPAYDto, CreateCL_COMMERTYPEPAYDto, UpdateCL_COMMERTYPEPAYDto, int>
{
    Task<IEnumerable<CL_COMMERTYPEPAYDto>> FindAsync(Expression<Func<CL_COMMERTYPEPAY, bool>> predicate);
}
