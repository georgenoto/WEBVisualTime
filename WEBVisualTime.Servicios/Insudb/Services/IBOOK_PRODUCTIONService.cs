using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_PRODUCTION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IBOOK_PRODUCTIONService : IService<BOOK_PRODUCTIONDto, CreateBOOK_PRODUCTIONDto, UpdateBOOK_PRODUCTIONDto, string>
{
    Task<IEnumerable<BOOK_PRODUCTIONDto>> FindAsync(Expression<Func<BOOK_PRODUCTION, bool>> predicate);
}
