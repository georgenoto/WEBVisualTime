using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IDOCUMENTSService : IService<DOCUMENTSDto, CreateDOCUMENTSDto, UpdateDOCUMENTSDto, string>
{
    Task<IEnumerable<DOCUMENTSDto>> FindAsync(Expression<Func<DOCUMENTS, bool>> predicate);
}
