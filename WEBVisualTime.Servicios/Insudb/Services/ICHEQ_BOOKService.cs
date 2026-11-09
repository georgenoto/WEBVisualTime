using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQ_BOOK;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICHEQ_BOOKService : IService<CHEQ_BOOKDto, CreateCHEQ_BOOKDto, UpdateCHEQ_BOOKDto, string>
{
    Task<IEnumerable<CHEQ_BOOKDto>> FindAsync(Expression<Func<CHEQ_BOOK, bool>> predicate);
}
