using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PROD;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILEND_AGREE_PRODService : IService<LEND_AGREE_PRODDto, CreateLEND_AGREE_PRODDto, UpdateLEND_AGREE_PRODDto, int>
{
    Task<IEnumerable<LEND_AGREE_PRODDto>> FindAsync(Expression<Func<LEND_AGREE_PROD, bool>> predicate);
}
