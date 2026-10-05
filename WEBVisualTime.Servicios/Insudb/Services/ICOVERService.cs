using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICOVERService : IService<COVERDto, CreateCOVERDto, UpdateCOVERDto, string>
{
    Task<IEnumerable<COVERDto>> FindAsync(Expression<Func<COVER, bool>> predicate);
}
