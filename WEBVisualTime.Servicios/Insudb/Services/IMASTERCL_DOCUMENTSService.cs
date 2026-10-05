using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DOCUMENTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IMASTERCL_DOCUMENTSService : IService<MASTERCL_DOCUMENTSDto, CreateMASTERCL_DOCUMENTSDto, UpdateMASTERCL_DOCUMENTSDto, long>
{
    Task<IEnumerable<MASTERCL_DOCUMENTSDto>> FindAsync(Expression<Func<MASTERCL_DOCUMENTS, bool>> predicate);
}
