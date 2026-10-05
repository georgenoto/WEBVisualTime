using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_COLLECTION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBOOK_COLLECTIONService : IService<BOOK_COLLECTIONDto, CreateBOOK_COLLECTIONDto, UpdateBOOK_COLLECTIONDto, string>
{
    Task<IEnumerable<BOOK_COLLECTIONDto>> FindAsync(Expression<Func<BOOK_COLLECTION, bool>> predicate);
}
