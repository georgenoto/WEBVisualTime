using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.IMAGES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IIMAGESService : IService<IMAGESDto, CreateIMAGESDto, UpdateIMAGESDto, string>
{
    Task<IEnumerable<IMAGESDto>> FindAsync(Expression<Func<IMAGES, bool>> predicate);
}
