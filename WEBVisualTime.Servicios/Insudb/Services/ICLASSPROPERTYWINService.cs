using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLASSPROPERTYWIN;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLASSPROPERTYWINService : IService<CLASSPROPERTYWINDto, CreateCLASSPROPERTYWINDto, UpdateCLASSPROPERTYWINDto, string>
{
    Task<IEnumerable<CLASSPROPERTYWINDto>> FindAsync(Expression<Func<CLASSPROPERTYWIN, bool>> predicate);
}
