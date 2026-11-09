using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCUMENTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLIDOCUMENTSService : IService<CLIDOCUMENTSDto, CreateCLIDOCUMENTSDto, UpdateCLIDOCUMENTSDto, string>
{
    Task<IEnumerable<CLIDOCUMENTSDto>> FindAsync(Expression<Func<CLIDOCUMENTS, bool>> predicate);
}
