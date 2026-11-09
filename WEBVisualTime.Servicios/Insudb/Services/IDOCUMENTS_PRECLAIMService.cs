using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS_PRECLAIM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDOCUMENTS_PRECLAIMService : IService<DOCUMENTS_PRECLAIMDto, CreateDOCUMENTS_PRECLAIMDto, UpdateDOCUMENTS_PRECLAIMDto, string>
{
    Task<IEnumerable<DOCUMENTS_PRECLAIMDto>> FindAsync(Expression<Func<DOCUMENTS_PRECLAIM, bool>> predicate);
}
