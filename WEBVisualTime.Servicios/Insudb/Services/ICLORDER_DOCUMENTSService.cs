using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DOCUMENTS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICLORDER_DOCUMENTSService : IService<CLORDER_DOCUMENTSDto, CreateCLORDER_DOCUMENTSDto, UpdateCLORDER_DOCUMENTSDto, long>
{
    Task<IEnumerable<CLORDER_DOCUMENTSDto>> FindAsync(Expression<Func<CLORDER_DOCUMENTS, bool>> predicate);
}
