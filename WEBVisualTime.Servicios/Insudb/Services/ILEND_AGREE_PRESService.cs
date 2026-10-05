using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PRES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILEND_AGREE_PRESService : IService<LEND_AGREE_PRESDto, CreateLEND_AGREE_PRESDto, UpdateLEND_AGREE_PRESDto, string>
{
    Task<IEnumerable<LEND_AGREE_PRESDto>> FindAsync(Expression<Func<LEND_AGREE_PRES, bool>> predicate);
}
